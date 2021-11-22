using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Util.Data.EntityFrameworkCore.Fakes;
using Util.Data.EntityFrameworkCore.Infrastructure;
using Util.Data.EntityFrameworkCore.Models;
using Util.Data.EntityFrameworkCore.Repositories;
using Util.Data.EntityFrameworkCore.UnitOfWorks;
using Xunit;

namespace Util.Data.EntityFrameworkCore.Tests {
    /// <summary>
    /// 订单仓储测试
    /// 说明:
    /// 1. 测试string类型标识
    /// 2. 测试一对多导航属性
    /// </summary>
    public class OrderRepositoryTest : TestBase {

        #region 测试初始化

        /// <summary>
        /// 仓储
        /// </summary>
        private readonly IOrderRepository _repository;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public OrderRepositoryTest(IOrderRepository repository, IPgSqlUnitOfWork unitOfWork ) : base(unitOfWork){
            _repository = repository;
        }

        #endregion

        #region 辅助方法

        /// <summary>
        /// 添加订单
        /// </summary>
        private Order AddOrder() {
            var order = OrderFakeService.GetOrder();
            order.Init();
            order.OrderItems.Add( CreateOrderItem() );
            order.OrderItems.Add( CreateOrderItem() );
            _repository.Add( order );
            UnitOfWork.Commit();
            UnitOfWork.ClearCache();
            return order;
        }

        /// <summary>
        /// 创建订单项
        /// </summary>
        private OrderItem CreateOrderItem() {
            var item = OrderItemFakeService.GetOrderItem();
            item.Init();
            return item;
        }

        /// <summary>
        /// 添加订单
        /// </summary>
        private async Task<Order> AddOrderAsync() {
            var order = OrderFakeService.GetOrder();
            order.Init();
            order.OrderItems.Add( CreateOrderItem() );
            order.OrderItems.Add( CreateOrderItem() );
            await _repository.AddAsync( order );
            await UnitOfWork.CommitAsync();
            UnitOfWork.ClearCache();
            return order;
        }

        #endregion

        #region Single

        /// <summary>
        /// 测试查找单个实体
        /// </summary>
        [Fact]
        public void TestSingle_1() {
            //添加实体
            var entity = AddOrder();

            //查找单个实体
            var result = _repository.Single( t => t.Id == entity.Id );

            //验证
            Assert.Empty( result.OrderItems );
        }

        /// <summary>
        /// 测试查找单个实体 - 使用Include包含子实体集合
        /// </summary>
        [Fact]
        public void TestSingle_2() {
            //添加实体
            var entity = AddOrder();

            //查找单个实体
            var result = _repository.Single( t => t.Id == entity.Id, queryable => queryable.Include( t => t.OrderItems ) );

            //验证
            Assert.Equal( 2, result.OrderItems.Count );
        }

        #endregion

        #region SingleAsync

        /// <summary>
        /// 测试查找单个实体
        /// </summary>
        [Fact]
        public async Task TestSingleAsync_1() {
            //添加实体
            var entity = await AddOrderAsync();

            //查找单个实体
            var result = await _repository.SingleAsync( t => t.Id == entity.Id );

            //验证
            Assert.Empty( result.OrderItems );
        }

        /// <summary>
        /// 测试查找单个实体 - 使用Include包含子实体集合
        /// </summary>
        [Fact]
        public async Task TestSingleAsync_2() {
            //添加实体
            var entity = await AddOrderAsync();

            //查找单个实体
            var result = await _repository.SingleAsync( t => t.Id == entity.Id, queryable => queryable.Include( t => t.OrderItems ) );

            //验证
            Assert.Equal( 2, result.OrderItems.Count );
        }

        #endregion
    }
}