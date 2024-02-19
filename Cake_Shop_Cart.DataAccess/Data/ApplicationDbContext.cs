using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cake_Shop_Cart.Models;

namespace Cake_Shop_Cart.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options) 
        {

        }

        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "慶生分享塔", DisplayOrder = 1 },
                new Category { Id = 2, Name = "個人小塔", DisplayOrder = 2 },
                new Category { Id = 3, Name = "冬季限定", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "經典切片禮盒",
                    Description = "一次擁有9種不同的經典澎派口味與親人好友一同分享分享甜甜分享生活",
                    Price = 1810, CategoryId = 1, ImageUrl = "" },
                new Product { Id = 2, Name = "9入經典小塔禮盒",
                    Description = "澎湃吸睛適合聚會慶生，免分切超方便",
                    Price =1280, CategoryId = 1, ImageUrl = "" },
                new Product { Id = 3, Name = "繽紛彩虹千層",
                    Description = "內餡選用蜂蜜取代砂糖，更加入玫瑰鹽來提味降低油膩感，使用天然花青素而非人工色素調製而出的動人色彩，是一場美味的視覺饗宴",
                    Price = 1810, CategoryId = 1, ImageUrl = ""},
                new Product { Id = 4, Name = "香芋玫好",
                    Description = "綻放的紫色玫瑰選用大甲芋頭手工製成綿密芋頭泥熬煮玫瑰草莓醬，白玉麻糬為中間夾層層層堆疊，口味獨特不甜膩慢慢品嚐感受甜蜜的滋味",
                    Price = 190, CategoryId = 2, ImageUrl = ""},
                new Product { Id = 5, Name = "甜蜜蜜",
                    Description = "四季春香緹、蜂蜜堅果慕斯、蜂蜜杏桃蛋糕",
                    Price = 210, CategoryId = 2, ImageUrl = "" },
                new Product { Id = 6, Name = "貝禮詩生巧塔",
                    Description = "咖啡塔皮，飄散出濃濃的成熟香味，貝禮詩奶酒則是無法抗拒的魅力，香醇滑順的口感，無法忘懷的滋味，正如戀愛中的你 / 妳一般; 58％生巧克力與牛奶巧克力調和，加上甜甜的奶酒香氣，搭配咖啡或茶飲，一起分享的這陶醉的時刻！",
                    Price = 190, CategoryId = 2, ImageUrl = ""},
                new Product { Id = 7, Name = "草莓蕾蒂派",
                    Description = "平凡卻不平凡的甜點 香草莎布列帶出第一層風味 中間夾層是手工草莓果醬與酸甜覆盆子",
                    Price = 190, CategoryId = 2, ImageUrl = "" },
                new Product { Id = 8, Name = "我的藍莓夜",
                    Description = "歐洲野生莓果果泥 調製而成的藍莓風味乳酪 新鮮藍莓滿滿覆蓋 薰衣草酥脆派皮",
                    Price = 190 , CategoryId = 2, ImageUrl = ""},
                new Product { Id = 9, Name = "豐禾日栗",
                    Description = "糖漬栗子與栗子泥是第一主角 鐵觀音茶的濃厚茶香 紅豆乳酪融合了一切美味",
                    Price = 190 , CategoryId = 2, ImageUrl = ""},
                new Product { Id = 10, Name = "冬季限定草莓卡士達塔", Description = "使用當季新鮮水果搭配手工塔皮, 塔皮使用法國知名奶油製作, 酥脆口感帶上濃濃的奶香味, 水果塔類皆以健康減糖製作, 好吃又不負擔",
                    Price = 2100, CategoryId = 3, ImageUrl = ""}
                );
            modelBuilder.Entity<Store>().HasData(
                 new Store { Id = 1, Name = "台北大安店", Address = "台北市大同區迪化街一段15巷86號", City = "台北市", PhoneNumber = "0912345678", Description = "每逢農曆新年便會成為人聲鼎沸的市集" }
                );
        }
    }
}
