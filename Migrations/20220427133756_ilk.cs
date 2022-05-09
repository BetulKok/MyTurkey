using Microsoft.EntityFrameworkCore.Migrations;

namespace MyTurkey.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolgeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BolgeAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolgeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BolgeId = table.Column<int>(type: "int", nullable: false),
                    SehirAd = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nufus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sehirler_Bolgeler_BolgeId",
                        column: x => x.BolgeId,
                        principalTable: "Bolgeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bolgeler",
                columns: new[] { "Id", "BolgeAd" },
                values: new object[,]
                {
                    { 1, "Akdeniz Bölgesi" },
                    { 2, "Doğu Anadolu Bölgesi" },
                    { 3, "Ege Bölgesi" },
                    { 4, "Güneydoğu Anadolu Bölgesi" },
                    { 5, "İç Anadolu Bölgesi" },
                    { 6, "Karadeniz Bölgesi" },
                    { 7, "Marmara Bölgesi" }
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "BolgeId", "Nufus", "SehirAd" },
                values: new object[,]
                {
                    { 1, 1, 2201670, "Adana" },
                    { 29, 6, 172034, "Gümüşhane" },
                    { 28, 6, 444467, "Giresun" },
                    { 19, 6, 527863, "Çorum" },
                    { 14, 6, 299896, "Bolu" },
                    { 8, 6, 168068, "Artvin" },
                    { 5, 6, 326351, "Amasya" },
                    { 71, 5, 277984, "Kırıkkale" },
                    { 37, 6, 376945, "Kastamonu" },
                    { 70, 5, 245610, "Karaman" },
                    { 66, 5, 421041, "Yozgat" },
                    { 58, 5, 621224, "Sivas" },
                    { 51, 5, 351468, "Niğde" },
                    { 50, 5, 290895, "Nevşehir" },
                    { 42, 5, 2161303, "Konya" },
                    { 40, 5, 229975, "Kırşehir" },
                    { 38, 5, 1358980, "Kayseri" },
                    { 68, 5, 396673, "Aksaray" },
                    { 52, 6, 750588, "Ordu" },
                    { 53, 6, 331048, "Rize" },
                    { 55, 6, 1295927, "Samsun" },
                    { 54, 7, 976948, "Sakarya" },
                    { 41, 7, 1830772, "Kocaeli" },
                    { 39, 7, 351684, "Kırklareli" },
                    { 34, 7, 14804116, "İstanbul" },
                    { 22, 7, 401701, "Edirne" },
                    { 17, 7, 519793, "Çanakkale" },
                    { 16, 7, 2901396, "Bursa" },
                    { 11, 7, 218297, "Bilecik" },
                    { 10, 7, 1196176, "Balıkesir" },
                    { 81, 6, 370371, "Düzce" },
                    { 78, 6, 242347, "Karabük" },
                    { 74, 6, 192389, "Bartın" },
                    { 69, 6, 90154, "Bayburt" },
                    { 67, 6, 597524, "Zonguldak" },
                    { 61, 6, 779379, "Trabzon" },
                    { 60, 6, 602662, "Tokat" },
                    { 57, 6, 205478, "Sinop" },
                    { 26, 5, 844842, "Eskişehir" },
                    { 59, 7, 972875, "Tekirdağ" },
                    { 18, 5, 183880, "Çankırı" },
                    { 79, 4, 130825, "Kilis" }
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Id", "BolgeId", "Nufus", "SehirAd" },
                values: new object[,]
                {
                    { 44, 2, 781305, "Malatya" },
                    { 36, 2, 289786, "Kars" },
                    { 30, 2, 267813, "Hakkari" },
                    { 25, 2, 762021, "Erzurum" },
                    { 24, 2, 226032, "Erzincan" },
                    { 23, 2, 578789, "Elazığ" },
                    { 13, 2, 341225, "Bitlis" },
                    { 49, 2, 406501, "Muş" },
                    { 12, 2, 269560, "Bingöl" },
                    { 80, 1, 522175, "Osmaniye" },
                    { 46, 1, 1112634, "Kahramanmaraş" },
                    { 33, 1, 1773852, "Mersin" },
                    { 32, 1, 427324, "Isparta" },
                    { 31, 1, 1555165, "Hatay" },
                    { 15, 1, 261401, "Burdur" },
                    { 7, 1, 2328555, "Antalya" },
                    { 4, 2, 542255, "Ağrı" },
                    { 62, 2, 82193, "Tunceli" },
                    { 65, 2, 1100190, "Van" },
                    { 75, 2, 98335, "Ardahan" },
                    { 73, 4, 483788, "Şırnak" },
                    { 72, 4, 576899, "Batman" },
                    { 63, 4, 1940627, "Şanlıurfa" },
                    { 56, 4, 322664, "Siirt" },
                    { 47, 4, 796237, "Mardin" },
                    { 27, 4, 1974244, "Gaziantep" },
                    { 21, 4, 1673119, "Diyarbakır" },
                    { 2, 4, 610484, "Adıyaman" },
                    { 64, 3, 358736, "Uşak" },
                    { 48, 3, 923773, "Muğla" },
                    { 45, 3, 1396945, "Manisa" },
                    { 43, 3, 573642, "Kütahya" },
                    { 35, 3, 4223545, "İzmir" },
                    { 20, 3, 1005687, "Denizli" },
                    { 9, 3, 1068260, "Aydın" },
                    { 3, 3, 714523, "Afyonkarahisar" },
                    { 76, 2, 192785, "Iğdır" },
                    { 6, 5, 5346518, "Ankara" },
                    { 77, 7, 241665, "Yalova" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sehirler_BolgeId",
                table: "Sehirler",
                column: "BolgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Bolgeler");
        }
    }
}
