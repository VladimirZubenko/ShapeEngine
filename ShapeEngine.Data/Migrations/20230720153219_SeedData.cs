using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShapeEngine.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shapes",
                columns: new[] { "Id", "Name", "ShapeType" },
                values: new object[,]
                {
                    { new Guid("00c2cb5a-2469-1b5a-1c9c-5dec45703795"), "Rectangle1", 1 },
                    { new Guid("022dea00-f565-b9ff-265b-7a5dc2bbcfb5"), "Rectangle166", 1 },
                    { new Guid("0470a4de-e475-cc94-b72d-17da8f14672d"), "Rectangle138", 1 },
                    { new Guid("09a9b5ec-4ff1-4557-2900-cf30cb05e9ff"), "Rectangle118", 1 },
                    { new Guid("0b19c87f-a9ac-1a6a-b60f-81fbeb4f3d16"), "Rectangle14", 1 },
                    { new Guid("0dfa902a-c2a8-8f93-c30e-ed531be36158"), "Rectangle117", 1 },
                    { new Guid("0e5618f9-a4ce-9337-9179-a58be10c7e96"), "Rectangle181", 1 },
                    { new Guid("0f3fb9be-1be2-721b-fdd6-b1dbc6a90957"), "Rectangle9", 1 },
                    { new Guid("0fb3e3e5-97ca-9ab9-b369-64df63169ddd"), "Rectangle47", 1 },
                    { new Guid("107faa47-862d-1686-64ec-36bcd8eaa706"), "Rectangle100", 1 },
                    { new Guid("129ec3fd-827e-c5f7-a954-b0484f45ba38"), "Rectangle190", 1 },
                    { new Guid("13dfca12-6a42-0cef-59d8-507164cce32f"), "Rectangle34", 1 },
                    { new Guid("14b38d22-8237-bfb5-de0c-7c2d95f9b2b9"), "Rectangle152", 1 },
                    { new Guid("15151b02-a2a7-09af-b508-6ed76e1df2e8"), "Rectangle51", 1 },
                    { new Guid("16238310-1257-db51-e212-02975fca2cc2"), "Rectangle40", 1 },
                    { new Guid("170f2038-72a4-761b-a5d5-1ac10959d5ca"), "Rectangle39", 1 },
                    { new Guid("17f499fb-93b1-ac0d-d49e-1b16f66c2084"), "Rectangle41", 1 },
                    { new Guid("1837fb87-8c80-2fe2-3de5-851b7b1c29fb"), "Rectangle49", 1 },
                    { new Guid("19028085-2b9d-8cec-a2be-3d1b74116716"), "Rectangle198", 1 },
                    { new Guid("1a2a48b9-41df-1b22-6ccd-aea89127d4c8"), "Rectangle8", 1 },
                    { new Guid("1c036160-5157-a994-ef07-c4b88323bce2"), "Rectangle22", 1 },
                    { new Guid("1d8f562e-029b-d558-72f8-2264d5a86178"), "Rectangle195", 1 },
                    { new Guid("1f868a0c-6ee9-47ab-3372-b3ac9dc69c3d"), "Rectangle184", 1 },
                    { new Guid("1fdb01a1-1ae7-d326-7621-e779c5983b76"), "Rectangle82", 1 },
                    { new Guid("21a97a27-a9e9-7cfa-1950-beb9a1d11212"), "Rectangle159", 1 },
                    { new Guid("231ae598-8f0c-387a-6ff7-6981c0859dc6"), "Rectangle84", 1 },
                    { new Guid("24c835e2-de12-eac4-6b25-d692546b46c1"), "Rectangle17", 1 },
                    { new Guid("2555c940-3884-f262-627e-7fbcb3009c88"), "Rectangle106", 1 },
                    { new Guid("27688d61-3018-c7a3-48fc-80903c3bf678"), "Rectangle24", 1 },
                    { new Guid("28058790-f46a-ec31-086b-d564b402596e"), "Rectangle144", 1 },
                    { new Guid("28fd3600-8963-7f02-6eae-68f89d0f4cb7"), "Rectangle97", 1 },
                    { new Guid("29ee8664-1a25-e8d9-6275-69db69c05782"), "Rectangle33", 1 },
                    { new Guid("2a012a34-d935-a6d0-f06c-1d19399a143a"), "Rectangle167", 1 },
                    { new Guid("2c50b4c2-a5d8-b806-68df-532fa7c6ec98"), "Rectangle62", 1 },
                    { new Guid("2d6edfdf-09e6-aa11-6830-18fc36b9d43c"), "Rectangle35", 1 },
                    { new Guid("2db7f625-bf32-57ee-1bca-fa0d9f5ff4d9"), "Rectangle52", 1 },
                    { new Guid("2e3e4f1c-cf61-378d-4632-991820965c3a"), "Rectangle55", 1 },
                    { new Guid("3035d2fc-b171-a5e0-c842-fb7c36f237f9"), "Rectangle130", 1 },
                    { new Guid("303d389d-2832-a934-3cf2-93f29f9dd2b2"), "Rectangle147", 1 },
                    { new Guid("336758e1-90b7-bd47-6367-aee7b368cc06"), "Rectangle50", 1 },
                    { new Guid("34894fa5-c10b-d8f7-b01d-f6c224fde3c3"), "Rectangle10", 1 },
                    { new Guid("34cf2c3b-e6a2-816d-2e44-ccbecfd0be17"), "Rectangle162", 1 },
                    { new Guid("38dfac91-2f97-00c2-6b00-3dab16e71f67"), "Rectangle143", 1 },
                    { new Guid("3a5908c6-a9a1-6fe5-14bd-3e24be71e64c"), "Rectangle12", 1 },
                    { new Guid("3a7eb1c5-294d-35b5-9430-22fea88a0e26"), "Rectangle79", 1 },
                    { new Guid("3ce03eb3-0f9e-a093-f328-a5fa7b763833"), "Rectangle171", 1 },
                    { new Guid("3d24d818-ca52-ff8f-8929-3ae4e072f6ca"), "Rectangle172", 1 },
                    { new Guid("3dfc83e4-ef66-2e4a-d492-634707a5f323"), "Rectangle188", 1 },
                    { new Guid("3ea37e30-a85c-e1e6-48ff-d8dca022714d"), "Rectangle116", 1 },
                    { new Guid("3f105459-7ce8-9c0b-3968-571476428150"), "Rectangle38", 1 },
                    { new Guid("40cb5017-ce99-922d-f32f-34f3a50f86c9"), "Rectangle64", 1 },
                    { new Guid("413faafd-7393-c8ba-6702-41f07e80acd7"), "Rectangle137", 1 },
                    { new Guid("41c4b5aa-6dea-c363-4d42-5659947a3cb2"), "Rectangle120", 1 },
                    { new Guid("42a48900-b3f5-4490-7746-99a042f69d04"), "Rectangle3", 1 },
                    { new Guid("434f78d6-4b00-059d-562e-7f1200fce396"), "Rectangle44", 1 },
                    { new Guid("43973915-90be-5c06-56dd-9485c346c629"), "Rectangle45", 1 },
                    { new Guid("443541d4-e78c-e425-b6df-07be9b0be719"), "Rectangle112", 1 },
                    { new Guid("4481b838-e954-dd1e-9fa6-3b0690f98c5d"), "Rectangle139", 1 },
                    { new Guid("44e9379e-1450-e3c1-e9b9-64423b924d07"), "Rectangle101", 1 },
                    { new Guid("44f8cf75-c6c4-84c0-8fff-70f3e8fa344f"), "Rectangle148", 1 },
                    { new Guid("4a86e21d-0989-48fc-1581-554b77eadbee"), "Rectangle153", 1 },
                    { new Guid("4c28273b-1c68-47f9-e951-4b25af60b994"), "Rectangle158", 1 },
                    { new Guid("4cca7a30-69a1-a3ae-8b72-23f3e93db1a7"), "Rectangle42", 1 },
                    { new Guid("4d2d36c5-a588-e435-6804-56f474a790be"), "Rectangle111", 1 },
                    { new Guid("4d4d57f8-4a7e-ce70-50e9-e442031a3f50"), "Rectangle125", 1 },
                    { new Guid("4e411548-2788-eea3-650a-5b76eb7063f7"), "Rectangle72", 1 },
                    { new Guid("502e7ac3-6b3e-9663-b3c4-3d5b0d935ed1"), "Rectangle114", 1 },
                    { new Guid("507689f8-271b-9360-38bc-88cc0794b001"), "Rectangle199", 1 },
                    { new Guid("5121ec2a-aa0e-861f-e169-52232ba0f413"), "Rectangle193", 1 },
                    { new Guid("53784a22-a8e6-8148-39c1-0a86fd447266"), "Rectangle108", 1 },
                    { new Guid("5616eb07-fad2-8657-20a8-a9566a310070"), "Rectangle30", 1 },
                    { new Guid("5acd19ca-2dc4-5198-de04-36d98767d991"), "Rectangle91", 1 },
                    { new Guid("5b9721b8-da76-9046-9773-149c207231f3"), "Rectangle25", 1 },
                    { new Guid("5cf87699-cf68-636c-08ae-42806dfe7292"), "Rectangle89", 1 },
                    { new Guid("602604b0-f2b9-7927-d12a-b2e8746119f8"), "Rectangle36", 1 },
                    { new Guid("60991c5b-63af-3754-df6f-b7869229070c"), "Rectangle140", 1 },
                    { new Guid("61b6666e-deba-1f88-e6ea-3a0040e3063c"), "Rectangle53", 1 },
                    { new Guid("64d28203-26be-91a8-21a4-d7258552e00a"), "Rectangle66", 1 },
                    { new Guid("65afa446-279a-adff-2e86-ff1006f27c44"), "Rectangle163", 1 },
                    { new Guid("666cf265-4716-9899-9112-b85ba718d6e0"), "Rectangle77", 1 },
                    { new Guid("674a5b79-5846-9bb3-2143-320816452523"), "Rectangle23", 1 },
                    { new Guid("69c42663-340d-2452-e12b-8a711e1f712a"), "Rectangle5", 1 },
                    { new Guid("6c93d106-2377-ac9f-0f63-cf46de241ecf"), "Rectangle11", 1 },
                    { new Guid("6d7e1561-5a42-3776-e44f-655790382842"), "Rectangle92", 1 },
                    { new Guid("70ba4948-9e0e-8593-2fb1-db0f40bd6714"), "Rectangle197", 1 },
                    { new Guid("710a05a6-9f00-3f6e-108c-2eb024aca859"), "Rectangle90", 1 },
                    { new Guid("7115bae7-a9b2-b31b-8f98-f3d5b4f3c221"), "Rectangle174", 1 },
                    { new Guid("75b6efb1-f7fe-c88d-ce17-bd4f7b5fdffa"), "Rectangle119", 1 },
                    { new Guid("7737b8b9-2996-bfdd-1727-4ac61d100a6a"), "Rectangle68", 1 },
                    { new Guid("7782cc16-346d-5ae4-27d6-927bdf9a57bf"), "Rectangle102", 1 },
                    { new Guid("7786a0e3-c9f9-2958-ddea-1c95e9239e27"), "Rectangle105", 1 },
                    { new Guid("7b37db38-4364-2701-1883-6d94623546ea"), "Rectangle18", 1 },
                    { new Guid("7ce2d7bd-cd53-4988-1e9d-d23d6b325edd"), "Rectangle136", 1 },
                    { new Guid("7da9f293-4b0a-b878-4ddc-e9f6a9d10940"), "Rectangle74", 1 },
                    { new Guid("7dfef5b9-09c4-885e-1dac-3e8eed0e1571"), "Rectangle43", 1 },
                    { new Guid("7fb2938f-1e65-c1df-7efb-bd481ec0e4e6"), "Rectangle126", 1 },
                    { new Guid("84c7845f-8b20-14b2-918f-ab5731597412"), "Rectangle94", 1 },
                    { new Guid("85f73e5d-db6d-4568-0134-3b27a4062c34"), "Rectangle146", 1 },
                    { new Guid("863e291c-d1a1-a10c-42a9-4bfc5650861c"), "Rectangle175", 1 },
                    { new Guid("87784a5e-29cc-738b-13f3-2aa791e09779"), "Rectangle183", 1 },
                    { new Guid("8c489491-8577-99cd-92c3-24001e4ef359"), "Rectangle124", 1 },
                    { new Guid("8d0d96c6-31e0-7cf6-2072-191e0d6b5cf1"), "Rectangle113", 1 },
                    { new Guid("8d602441-288d-a27e-ce6a-c64495b24acb"), "Rectangle93", 1 },
                    { new Guid("8e41fa3e-863f-e902-6907-7660401a7de6"), "Rectangle32", 1 },
                    { new Guid("8f925157-7f45-11a5-d22d-75a235faa9bc"), "Rectangle65", 1 },
                    { new Guid("8fd37a2c-8d02-3a82-1a42-5d023be1fb3f"), "Rectangle165", 1 },
                    { new Guid("91917c7b-b6d9-bbd0-2d18-57c0974af437"), "Rectangle149", 1 },
                    { new Guid("953284b8-b292-e221-6865-1f94aaae8b99"), "Rectangle176", 1 },
                    { new Guid("96973aa0-108e-ed71-7642-22d2c0cfa55d"), "Rectangle196", 1 },
                    { new Guid("96eecc1f-f858-df1c-eee4-b54ede86489c"), "Rectangle75", 1 },
                    { new Guid("988ea22f-2615-f10a-b166-e5e6ff93d773"), "Rectangle178", 1 },
                    { new Guid("99508c9a-4ef4-2e19-86aa-c72da0c95990"), "Rectangle29", 1 },
                    { new Guid("99cc83a5-fc59-58c5-4314-6010179e7a1d"), "Rectangle73", 1 },
                    { new Guid("9a86c369-6b0c-b985-fd4d-1e5d21e2a81e"), "Rectangle80", 1 },
                    { new Guid("9aaa47bf-7cfc-b8b2-d24d-3dbb68360b01"), "Rectangle85", 1 },
                    { new Guid("9abddb69-1fd7-1bf6-9028-22a9ed2d2f9d"), "Rectangle98", 1 },
                    { new Guid("9c036704-bf33-aeaa-3ac3-5d0561026a7f"), "Rectangle76", 1 },
                    { new Guid("9c6b938a-ae21-1704-6684-d9448e307263"), "Rectangle141", 1 },
                    { new Guid("9d158a53-8136-3d3e-5bdf-06a23fc8f1e3"), "Rectangle78", 1 },
                    { new Guid("9d397c3b-242c-8187-5b4a-daaceca70df8"), "Rectangle7", 1 },
                    { new Guid("9e2a8fe7-5d1b-50e2-75bd-5ce2f06e6621"), "Rectangle13", 1 },
                    { new Guid("9e3990c7-7634-af3b-eef7-23a8117e4beb"), "Rectangle186", 1 },
                    { new Guid("a30664a7-6f7c-8e1d-27c3-fe869fac97c3"), "Rectangle96", 1 },
                    { new Guid("a5e30094-19f9-fb32-d1e0-e3c239f79fcd"), "Rectangle177", 1 },
                    { new Guid("a63febd7-8649-e66f-40b3-12bffa111fb9"), "Rectangle19", 1 },
                    { new Guid("a691bdb8-8249-f784-0afd-fbd3cc126162"), "Rectangle69", 1 },
                    { new Guid("a9f6a116-b1b0-9031-78c8-e20b4fcd62af"), "Rectangle131", 1 },
                    { new Guid("aee54e20-f5b0-1657-8b93-b72c02d9c8e3"), "Rectangle27", 1 },
                    { new Guid("b307f16b-a703-0fca-36e3-9ed0637db79e"), "Rectangle168", 1 },
                    { new Guid("b58ddcde-644f-1c33-717b-6149c8da020a"), "Rectangle107", 1 },
                    { new Guid("b7fced86-fec2-906c-d286-86124156f077"), "Rectangle179", 1 },
                    { new Guid("b92777ca-38f5-a1df-7e27-a0e117be2fcc"), "Rectangle104", 1 },
                    { new Guid("bea2ceec-11f1-521a-a0bd-7711598e3cba"), "Rectangle173", 1 },
                    { new Guid("c233339a-ab6a-ac2a-a854-2dcaf17b8307"), "Rectangle28", 1 },
                    { new Guid("c2559da7-256b-eeb7-9782-30075b0a95a5"), "Rectangle121", 1 },
                    { new Guid("c2587625-f94d-2da2-75e1-ceda5559456c"), "Rectangle86", 1 },
                    { new Guid("c27aacc8-acaf-d342-4221-86776775b563"), "Rectangle6", 1 },
                    { new Guid("c30814d3-bb97-4a34-7b3e-d226223e1c65"), "Rectangle135", 1 },
                    { new Guid("c355826f-8291-bf60-1b35-ba7323f13226"), "Rectangle46", 1 },
                    { new Guid("c39f5a72-d208-ea5e-8c7d-602caa143cf9"), "Rectangle99", 1 },
                    { new Guid("c430c395-4493-6c05-b7b4-82e3a62e3d9f"), "Rectangle70", 1 },
                    { new Guid("c4d944fa-17c6-838e-285e-386144f3e635"), "Rectangle161", 1 },
                    { new Guid("c4e3800c-2c1a-02e9-cf80-fd3116933c5f"), "Rectangle21", 1 },
                    { new Guid("c52e968e-9a52-c70d-7d2f-97f88c22bdbb"), "Rectangle115", 1 },
                    { new Guid("c631668b-768f-2f5c-e193-5fe2c33c6714"), "Rectangle88", 1 },
                    { new Guid("c6ec4a1a-8d23-c730-ffeb-25a9e655f2fe"), "Rectangle170", 1 },
                    { new Guid("c80ccf8c-82e4-95dc-a4ee-586bd11e06c9"), "Rectangle155", 1 },
                    { new Guid("c9829083-d68f-509d-7335-6f85e46046e0"), "Rectangle192", 1 },
                    { new Guid("ca1ce149-019b-84e9-aa11-f720ccf3b895"), "Rectangle191", 1 },
                    { new Guid("cb8e69e0-97cd-cb71-5993-26c1fb37f93b"), "Rectangle157", 1 },
                    { new Guid("cba75903-7e3e-cc4d-9e89-01ce3a4e8912"), "Rectangle26", 1 },
                    { new Guid("cc51157a-1595-4c33-afd0-7397bd34f462"), "Rectangle189", 1 },
                    { new Guid("cc75fc4e-b195-9dd0-a6c5-eea199d097e0"), "Rectangle95", 1 },
                    { new Guid("cf0323e5-496c-5eaa-1f70-16742ca7708e"), "Rectangle122", 1 },
                    { new Guid("d25ae26b-9a99-2bf5-a0ec-c4abf10e8f36"), "Rectangle185", 1 },
                    { new Guid("d2807232-4060-4a36-97ff-97d3602c14a7"), "Rectangle59", 1 },
                    { new Guid("d2e0941d-13d7-3f43-3fff-5521187454b6"), "Rectangle109", 1 },
                    { new Guid("d40fe671-4324-db55-3412-ff961b071778"), "Rectangle67", 1 },
                    { new Guid("d4be6ec7-da93-6cb6-5d76-9cdbf0c4eb63"), "Rectangle123", 1 },
                    { new Guid("d57f05d3-986a-8e34-fb0d-1e1cbd3067aa"), "Rectangle83", 1 },
                    { new Guid("d66dd9fc-8734-870d-d07c-082b0103f016"), "Rectangle127", 1 },
                    { new Guid("d6c20696-a5af-bd1f-a61c-f0f552fb8287"), "Rectangle182", 1 },
                    { new Guid("d77151b7-2509-309a-5e9c-0a9edb34403d"), "Rectangle48", 1 },
                    { new Guid("d8edbb0f-5097-4474-d75c-427cf67531ab"), "Rectangle128", 1 },
                    { new Guid("d8f2c1b2-22ee-a4f5-96e4-f3ebaaec07f3"), "Rectangle150", 1 },
                    { new Guid("db9631f1-4e22-52c3-835b-9b614823f479"), "Rectangle164", 1 },
                    { new Guid("ddb9c3cc-b3fe-707f-f885-7f93bf37030d"), "Rectangle180", 1 },
                    { new Guid("de1aabfc-b112-376e-1836-5a49d6eaa77a"), "Rectangle151", 1 },
                    { new Guid("df949aa7-214c-c52f-e0cf-302c97c0ca75"), "Rectangle4", 1 },
                    { new Guid("dfdc9bd4-45d7-2a66-feb1-faa6989aaa88"), "Rectangle81", 1 },
                    { new Guid("e1d888b2-b6cf-c80b-0fb2-75bc27bf2673"), "Rectangle145", 1 },
                    { new Guid("e2456da0-f70a-95da-5295-09641e009768"), "Rectangle154", 1 },
                    { new Guid("e39df5dd-e61e-c4f5-5f15-ed7c6f98c697"), "Rectangle71", 1 },
                    { new Guid("e512b5f7-d2c7-7bbb-d976-9c228b83abe9"), "Rectangle160", 1 },
                    { new Guid("e5e243df-c4b1-d035-d4da-bf71451be3c2"), "Rectangle132", 1 },
                    { new Guid("e60739fc-9638-cd5b-aaba-4713f9c9bf13"), "Rectangle57", 1 },
                    { new Guid("e696ad10-d5c2-0f9e-1631-682ef2de619a"), "Rectangle63", 1 },
                    { new Guid("e6dcb8dc-e53b-890c-7f2f-32e86a694aba"), "Rectangle134", 1 },
                    { new Guid("e7589363-cbd4-89c8-5361-af71cce01a4b"), "Rectangle31", 1 },
                    { new Guid("e78b6e73-65d7-14e5-2c17-8a01610eb906"), "Rectangle187", 1 },
                    { new Guid("e99f14f7-4e48-119e-536f-b488c18f3448"), "Rectangle110", 1 },
                    { new Guid("eb2e251b-8c1c-78d0-f7cb-002d49330f9a"), "Rectangle87", 1 },
                    { new Guid("ee72f412-8473-7247-f7c1-c5c0285464e4"), "Rectangle61", 1 },
                    { new Guid("ef938078-0e91-ba82-1135-c26daadf1992"), "Rectangle142", 1 },
                    { new Guid("f00194c0-bd1f-4eed-908d-86a69ab55815"), "Rectangle169", 1 },
                    { new Guid("f11e4571-fa3f-c11d-437f-d81e07a8c0a6"), "Rectangle16", 1 },
                    { new Guid("f13a1a86-937f-68e0-4060-52fd3715a9d8"), "Rectangle200", 1 },
                    { new Guid("f333db94-f998-8374-a125-af7d94171270"), "Rectangle60", 1 },
                    { new Guid("f35389e3-d31e-3cb9-32e4-6df93cbe8a3f"), "Rectangle194", 1 },
                    { new Guid("f3cafa40-5ac7-12ee-8840-19d94d4dd63a"), "Rectangle37", 1 },
                    { new Guid("f4e0c2f2-b82d-855e-4d13-4020bec28906"), "Rectangle103", 1 },
                    { new Guid("f604ec93-484b-46a1-a1a7-97223c2d8387"), "Rectangle133", 1 },
                    { new Guid("f670d4ae-7755-984e-3a49-f0896bd50790"), "Rectangle56", 1 },
                    { new Guid("fa9a2762-38ea-4934-91ea-8d78b47bb49d"), "Rectangle129", 1 },
                    { new Guid("faaceb45-0c82-be16-365f-84e4baf31787"), "Rectangle2", 1 },
                    { new Guid("fb8c525f-5b67-c464-5dc0-5178182ed972"), "Rectangle54", 1 },
                    { new Guid("fbd3278e-fd98-690d-a67c-a88f575a80fe"), "Rectangle20", 1 },
                    { new Guid("fbdcbd39-0e5f-f43e-23a2-e784db4a2778"), "Rectangle156", 1 },
                    { new Guid("fc01d7b5-55c7-7a4e-3082-762ad9fae1c8"), "Rectangle15", 1 },
                    { new Guid("fd7989db-e04e-eac9-5ee9-25a296c84d4b"), "Rectangle58", 1 }
                });

            migrationBuilder.InsertData(
                table: "Points",
                columns: new[] { "Id", "PointType", "ShapeId", "X", "Y" },
                values: new object[,]
                {
                    { new Guid("00335a38-1f5f-a097-2292-eb99d7c7d2db"), 2, new Guid("c631668b-768f-2f5c-e193-5fe2c33c6714"), 920L, 895L },
                    { new Guid("0044632a-831b-a99d-2ac1-c586c7a6411e"), 2, new Guid("170f2038-72a4-761b-a5d5-1ac10959d5ca"), 430L, 405L },
                    { new Guid("005d60a4-051a-608c-311e-eba7943cd493"), 1, new Guid("4e411548-2788-eea3-650a-5b76eb7063f7"), 710L, 710L },
                    { new Guid("00b538ed-1121-1b39-3327-bdf9ff7858ee"), 2, new Guid("fb8c525f-5b67-c464-5dc0-5178182ed972"), 580L, 555L },
                    { new Guid("02aa0108-98c4-e4bd-8873-f326fd6af42b"), 1, new Guid("17f499fb-93b1-ac0d-d49e-1b16f66c2084"), 400L, 400L },
                    { new Guid("036f9fe7-a87a-d6f7-b952-cb161064a263"), 1, new Guid("dfdc9bd4-45d7-2a66-feb1-faa6989aaa88"), 800L, 800L },
                    { new Guid("03a26c61-1a50-597a-c361-8137c05d7ff9"), 2, new Guid("602604b0-f2b9-7927-d12a-b2e8746119f8"), 400L, 375L },
                    { new Guid("055515f0-c977-a89c-fcf0-f31b16032b54"), 1, new Guid("14b38d22-8237-bfb5-de0c-7c2d95f9b2b9"), 1510L, 1510L },
                    { new Guid("05589b07-4cbf-0786-2751-2a0260aa177f"), 2, new Guid("7fb2938f-1e65-c1df-7efb-bd481ec0e4e6"), 1300L, 1275L },
                    { new Guid("06ac826b-57de-5baa-64bc-2cfbd341c852"), 1, new Guid("3d24d818-ca52-ff8f-8929-3ae4e072f6ca"), 1710L, 1710L },
                    { new Guid("072c8a3a-9d8f-7e27-79e4-1b36b56ac3a0"), 2, new Guid("00c2cb5a-2469-1b5a-1c9c-5dec45703795"), 50L, 25L },
                    { new Guid("0794ec39-6354-3e27-23a5-4df2e0afea3d"), 2, new Guid("5acd19ca-2dc4-5198-de04-36d98767d991"), 950L, 925L },
                    { new Guid("07beb60f-a93c-ab8a-64f9-dfc9bedd82b7"), 1, new Guid("9d158a53-8136-3d3e-5bdf-06a23fc8f1e3"), 770L, 770L },
                    { new Guid("082c6606-c726-f8e7-7d6e-7fc7c6e1c8b5"), 1, new Guid("0470a4de-e475-cc94-b72d-17da8f14672d"), 1370L, 1370L },
                    { new Guid("0834c095-405b-9117-a4cd-e6a0c92f7521"), 2, new Guid("b7fced86-fec2-906c-d286-86124156f077"), 1830L, 1805L },
                    { new Guid("08592f62-13d8-502f-71d9-42e2900f2e69"), 2, new Guid("ddb9c3cc-b3fe-707f-f885-7f93bf37030d"), 1840L, 1815L },
                    { new Guid("0911fa8a-5940-268b-0923-4bc372c4f006"), 2, new Guid("7dfef5b9-09c4-885e-1dac-3e8eed0e1571"), 470L, 445L },
                    { new Guid("096e5289-c19b-6137-35da-881fccd5339b"), 1, new Guid("fbd3278e-fd98-690d-a67c-a88f575a80fe"), 190L, 190L },
                    { new Guid("09c7d026-d3f6-bf20-4bcc-64b64df3558e"), 1, new Guid("09a9b5ec-4ff1-4557-2900-cf30cb05e9ff"), 1170L, 1170L },
                    { new Guid("0ac6959b-17da-35fc-aedc-6bb450eaa696"), 2, new Guid("f13a1a86-937f-68e0-4060-52fd3715a9d8"), 2040L, 2015L },
                    { new Guid("0b158981-9df7-9055-ec26-e9a0dad0a2ce"), 1, new Guid("8c489491-8577-99cd-92c3-24001e4ef359"), 1230L, 1230L },
                    { new Guid("0beeb48d-62c4-6069-50f5-a98595f3fecd"), 1, new Guid("3a5908c6-a9a1-6fe5-14bd-3e24be71e64c"), 110L, 110L },
                    { new Guid("0d305d61-4f3b-aa14-9de8-2c589f43e5ba"), 1, new Guid("5b9721b8-da76-9046-9773-149c207231f3"), 240L, 240L },
                    { new Guid("0e589f48-5526-1e9c-b2dc-8cab21ae9cab"), 1, new Guid("9e2a8fe7-5d1b-50e2-75bd-5ce2f06e6621"), 120L, 120L },
                    { new Guid("0f30ed65-e718-e348-3f43-598a27921acf"), 1, new Guid("0fb3e3e5-97ca-9ab9-b369-64df63169ddd"), 460L, 460L },
                    { new Guid("0f9257c0-5283-b1b0-26e2-5cd64cf0fb64"), 1, new Guid("ef938078-0e91-ba82-1135-c26daadf1992"), 1410L, 1410L },
                    { new Guid("0fbc2856-acb4-4df3-01da-9be9f63b1565"), 2, new Guid("e2456da0-f70a-95da-5295-09641e009768"), 1580L, 1555L },
                    { new Guid("107f18dd-6f7e-80b0-df56-57b20e2dd558"), 1, new Guid("84c7845f-8b20-14b2-918f-ab5731597412"), 930L, 930L },
                    { new Guid("1106285e-cbb5-dd69-d916-30c78e807e92"), 1, new Guid("13dfca12-6a42-0cef-59d8-507164cce32f"), 330L, 330L },
                    { new Guid("129b85ba-36ed-f4bb-01c6-d8820e05759f"), 2, new Guid("34cf2c3b-e6a2-816d-2e44-ccbecfd0be17"), 1660L, 1635L },
                    { new Guid("134fb2e5-c641-62e5-0044-e8183027ed15"), 2, new Guid("8d602441-288d-a27e-ce6a-c64495b24acb"), 970L, 945L },
                    { new Guid("139bea29-1230-7cdb-9273-05cdf5e6c917"), 2, new Guid("502e7ac3-6b3e-9663-b3c4-3d5b0d935ed1"), 1180L, 1155L },
                    { new Guid("13c3b123-cfb9-993c-22a4-d75e07b01fd5"), 2, new Guid("1f868a0c-6ee9-47ab-3372-b3ac9dc69c3d"), 1880L, 1855L },
                    { new Guid("14190072-b337-a01a-ac93-323da0a6ad44"), 2, new Guid("27688d61-3018-c7a3-48fc-80903c3bf678"), 280L, 255L },
                    { new Guid("1441fdef-f8c9-2d60-e9ca-1d5742409761"), 1, new Guid("a691bdb8-8249-f784-0afd-fbd3cc126162"), 680L, 680L },
                    { new Guid("14d75d10-a36c-f3dd-9da5-8be54cde2506"), 1, new Guid("df949aa7-214c-c52f-e0cf-302c97c0ca75"), 30L, 30L },
                    { new Guid("15b863a5-3315-f8fc-9bd6-e65c7216d33d"), 1, new Guid("c30814d3-bb97-4a34-7b3e-d226223e1c65"), 1340L, 1340L },
                    { new Guid("15fbcb1f-084b-adb8-2f4c-371ac2ce4754"), 1, new Guid("2e3e4f1c-cf61-378d-4632-991820965c3a"), 540L, 540L },
                    { new Guid("161c664c-c3e2-fdac-7830-afc166ad6465"), 2, new Guid("9e2a8fe7-5d1b-50e2-75bd-5ce2f06e6621"), 170L, 145L },
                    { new Guid("1679a348-9d6d-0704-f0d4-8f3238e30fa0"), 1, new Guid("c2559da7-256b-eeb7-9782-30075b0a95a5"), 1200L, 1200L },
                    { new Guid("16d9fa62-49de-5e3e-5ed1-85cd29b4d728"), 1, new Guid("413faafd-7393-c8ba-6702-41f07e80acd7"), 1360L, 1360L },
                    { new Guid("16ed1707-5c9a-e14e-ee9a-0f06942e92d7"), 2, new Guid("022dea00-f565-b9ff-265b-7a5dc2bbcfb5"), 1700L, 1675L },
                    { new Guid("17043325-15e1-c707-86b7-4d55bee75597"), 1, new Guid("75b6efb1-f7fe-c88d-ce17-bd4f7b5fdffa"), 1180L, 1180L },
                    { new Guid("17620c6c-ffb9-e58e-edd5-05b64d3ad337"), 2, new Guid("953284b8-b292-e221-6865-1f94aaae8b99"), 1800L, 1775L },
                    { new Guid("19c257d7-4836-a560-79ae-329c6ddcb25d"), 1, new Guid("303d389d-2832-a934-3cf2-93f29f9dd2b2"), 1460L, 1460L },
                    { new Guid("1a806b0d-4ed9-8d0b-2076-96cec17854be"), 1, new Guid("ee72f412-8473-7247-f7c1-c5c0285464e4"), 600L, 600L },
                    { new Guid("1bfc2d16-e002-9537-5fe5-ddc279136ad3"), 1, new Guid("fc01d7b5-55c7-7a4e-3082-762ad9fae1c8"), 140L, 140L },
                    { new Guid("1c7242f6-e2c7-779c-99a9-cee492f43cdf"), 2, new Guid("64d28203-26be-91a8-21a4-d7258552e00a"), 700L, 675L },
                    { new Guid("1dbfbb56-65eb-179c-b17c-2f8c4827d31f"), 1, new Guid("988ea22f-2615-f10a-b166-e5e6ff93d773"), 1770L, 1770L },
                    { new Guid("1e10cc09-c69d-4230-a913-365973223a80"), 1, new Guid("8f925157-7f45-11a5-d22d-75a235faa9bc"), 640L, 640L },
                    { new Guid("1e3dc39a-5af9-b420-5a19-1c54dfa31e6f"), 1, new Guid("a5e30094-19f9-fb32-d1e0-e3c239f79fcd"), 1760L, 1760L },
                    { new Guid("1e731e75-a3e2-e261-0063-a081b5c10eea"), 2, new Guid("84c7845f-8b20-14b2-918f-ab5731597412"), 980L, 955L },
                    { new Guid("1ea1f31d-1aaf-3f02-f183-081d7285722c"), 2, new Guid("a691bdb8-8249-f784-0afd-fbd3cc126162"), 730L, 705L },
                    { new Guid("20070a9d-c6cb-534e-51e8-a31fde1a4ab5"), 2, new Guid("3dfc83e4-ef66-2e4a-d492-634707a5f323"), 1920L, 1895L },
                    { new Guid("2314cc3c-4c24-848b-d9c6-e5ac0728b8d4"), 1, new Guid("d6c20696-a5af-bd1f-a61c-f0f552fb8287"), 1810L, 1810L },
                    { new Guid("2394e5d0-05ca-68a4-c869-29294d2cee78"), 2, new Guid("8fd37a2c-8d02-3a82-1a42-5d023be1fb3f"), 1690L, 1665L },
                    { new Guid("25e11225-26ad-a484-e915-08ebde68c855"), 1, new Guid("fa9a2762-38ea-4934-91ea-8d78b47bb49d"), 1280L, 1280L },
                    { new Guid("2776cd59-9cd4-43af-92df-8bc4992c9552"), 1, new Guid("674a5b79-5846-9bb3-2143-320816452523"), 220L, 220L },
                    { new Guid("279575e9-9dc9-027d-3708-e70cf278f10a"), 1, new Guid("e39df5dd-e61e-c4f5-5f15-ed7c6f98c697"), 700L, 700L },
                    { new Guid("27eb9b1d-4310-ba76-71fd-2130e916611b"), 2, new Guid("a63febd7-8649-e66f-40b3-12bffa111fb9"), 230L, 205L },
                    { new Guid("288769ac-a79f-9967-cb07-c2be1732870f"), 2, new Guid("e5e243df-c4b1-d035-d4da-bf71451be3c2"), 1360L, 1335L },
                    { new Guid("2a78bbce-12de-8a25-e898-fa988867c9f9"), 1, new Guid("f604ec93-484b-46a1-a1a7-97223c2d8387"), 1320L, 1320L },
                    { new Guid("2a8e290d-a56b-ee90-4a53-52a026e562a3"), 2, new Guid("9c6b938a-ae21-1704-6684-d9448e307263"), 1450L, 1425L },
                    { new Guid("2b16f159-2f5b-b858-0073-f2f4a4757cd8"), 2, new Guid("e6dcb8dc-e53b-890c-7f2f-32e86a694aba"), 1380L, 1355L },
                    { new Guid("2b29ac9c-7d74-c452-9c71-3178783799b8"), 1, new Guid("c39f5a72-d208-ea5e-8c7d-602caa143cf9"), 980L, 980L },
                    { new Guid("2c8634ad-cb2d-ba7b-e3e2-6fc288e1f156"), 1, new Guid("7dfef5b9-09c4-885e-1dac-3e8eed0e1571"), 420L, 420L },
                    { new Guid("2cfc564b-9070-84bd-82c3-18d173c2aa8a"), 2, new Guid("2c50b4c2-a5d8-b806-68df-532fa7c6ec98"), 660L, 635L },
                    { new Guid("2d9e4fb2-bd69-3665-274c-9d4f9bcf6d0c"), 2, new Guid("99cc83a5-fc59-58c5-4314-6010179e7a1d"), 770L, 745L },
                    { new Guid("2de65905-c09f-0df5-670c-dea0c7a04461"), 2, new Guid("e696ad10-d5c2-0f9e-1631-682ef2de619a"), 670L, 645L },
                    { new Guid("2e24164d-ac60-a332-8f0d-46486f46108b"), 2, new Guid("99508c9a-4ef4-2e19-86aa-c72da0c95990"), 330L, 305L },
                    { new Guid("2e70b533-148a-5aae-2695-17a74121097b"), 1, new Guid("27688d61-3018-c7a3-48fc-80903c3bf678"), 230L, 230L },
                    { new Guid("30301d16-6824-eb5f-4d4d-2736fedda3ac"), 2, new Guid("8c489491-8577-99cd-92c3-24001e4ef359"), 1280L, 1255L },
                    { new Guid("3060bfdb-1027-8667-137b-f80a97818d40"), 1, new Guid("9e3990c7-7634-af3b-eef7-23a8117e4beb"), 1850L, 1850L },
                    { new Guid("30a30bdf-5a26-81a9-30ca-284719353ea5"), 1, new Guid("336758e1-90b7-bd47-6367-aee7b368cc06"), 490L, 490L },
                    { new Guid("310e3d6c-5c68-29e4-cc1e-e761f26c5a7e"), 2, new Guid("5121ec2a-aa0e-861f-e169-52232ba0f413"), 1970L, 1945L },
                    { new Guid("312fb42f-d0ca-bd80-4e0d-914266893e36"), 1, new Guid("5acd19ca-2dc4-5198-de04-36d98767d991"), 900L, 900L },
                    { new Guid("33141f07-a4fa-c42c-14fe-41680b4a22d5"), 1, new Guid("53784a22-a8e6-8148-39c1-0a86fd447266"), 1070L, 1070L },
                    { new Guid("335d82fd-744c-8282-83eb-8f5ac1a6d6ef"), 1, new Guid("1d8f562e-029b-d558-72f8-2264d5a86178"), 1940L, 1940L },
                    { new Guid("33e3b07b-339b-f431-e4d1-a510fd609ac9"), 1, new Guid("c52e968e-9a52-c70d-7d2f-97f88c22bdbb"), 1140L, 1140L },
                    { new Guid("33fbc99e-f3a1-ef8d-2a2f-4722ad66a64b"), 1, new Guid("9c036704-bf33-aeaa-3ac3-5d0561026a7f"), 750L, 750L },
                    { new Guid("341e499c-45a1-72b2-0c4a-ca5048ec736d"), 2, new Guid("2555c940-3884-f262-627e-7fbcb3009c88"), 1100L, 1075L },
                    { new Guid("349e0e23-5a22-45b0-2c61-3b524abf1417"), 2, new Guid("4d4d57f8-4a7e-ce70-50e9-e442031a3f50"), 1290L, 1265L },
                    { new Guid("3532271a-b5ab-f67f-78e4-066142e56f45"), 1, new Guid("022dea00-f565-b9ff-265b-7a5dc2bbcfb5"), 1650L, 1650L },
                    { new Guid("355ca7a8-b823-4a28-4982-f709800a9638"), 2, new Guid("c27aacc8-acaf-d342-4221-86776775b563"), 100L, 75L },
                    { new Guid("35c3edaa-ba66-b593-d0c1-2a21657c9512"), 2, new Guid("fd7989db-e04e-eac9-5ee9-25a296c84d4b"), 620L, 595L },
                    { new Guid("362e024c-b1d5-0013-a643-149e566a74c7"), 2, new Guid("fbdcbd39-0e5f-f43e-23a2-e784db4a2778"), 1600L, 1575L },
                    { new Guid("36fc422f-ba2e-f1cd-1179-af6761ec01eb"), 2, new Guid("336758e1-90b7-bd47-6367-aee7b368cc06"), 540L, 515L },
                    { new Guid("3710b129-b6ea-c1a9-81e4-685a19de8032"), 2, new Guid("c4e3800c-2c1a-02e9-cf80-fd3116933c5f"), 250L, 225L },
                    { new Guid("37793a02-4bdd-bf68-3d22-cb2798977f27"), 1, new Guid("cf0323e5-496c-5eaa-1f70-16742ca7708e"), 1210L, 1210L },
                    { new Guid("37ee0ea7-384d-fa46-0c5a-8005baaa46d1"), 1, new Guid("d66dd9fc-8734-870d-d07c-082b0103f016"), 1260L, 1260L },
                    { new Guid("386abeea-7094-db23-5ac0-553fd1ff50eb"), 2, new Guid("75b6efb1-f7fe-c88d-ce17-bd4f7b5fdffa"), 1230L, 1205L },
                    { new Guid("39761630-fe46-1590-d4c0-67950d83088b"), 1, new Guid("e512b5f7-d2c7-7bbb-d976-9c228b83abe9"), 1590L, 1590L },
                    { new Guid("39d2ccd1-da2e-75a4-7e7d-b501f0e6d92b"), 1, new Guid("e78b6e73-65d7-14e5-2c17-8a01610eb906"), 1860L, 1860L },
                    { new Guid("3a35ba9c-e9c8-4800-763d-e6d35c0a38e6"), 2, new Guid("a5e30094-19f9-fb32-d1e0-e3c239f79fcd"), 1810L, 1785L },
                    { new Guid("3a3cc48c-bb6f-258c-8efa-bec232c43537"), 2, new Guid("38dfac91-2f97-00c2-6b00-3dab16e71f67"), 1470L, 1445L },
                    { new Guid("3aeacb07-fd38-c136-de7a-898204513cf5"), 2, new Guid("40cb5017-ce99-922d-f32f-34f3a50f86c9"), 680L, 655L },
                    { new Guid("3af956cf-2e03-3936-2cac-80cfe8b72456"), 2, new Guid("7737b8b9-2996-bfdd-1727-4ac61d100a6a"), 720L, 695L },
                    { new Guid("3bd7e1c0-025c-c9e2-c84f-d69a8125995c"), 1, new Guid("f11e4571-fa3f-c11d-437f-d81e07a8c0a6"), 150L, 150L },
                    { new Guid("3c108858-b385-623c-09df-414f70b37db9"), 2, new Guid("34894fa5-c10b-d8f7-b01d-f6c224fde3c3"), 140L, 115L },
                    { new Guid("3c2f5d70-553c-606f-b122-1ba00fe7ab33"), 1, new Guid("fbdcbd39-0e5f-f43e-23a2-e784db4a2778"), 1550L, 1550L },
                    { new Guid("3cb736a6-d7e0-1ab6-c166-f34737cba13e"), 2, new Guid("7782cc16-346d-5ae4-27d6-927bdf9a57bf"), 1060L, 1035L },
                    { new Guid("3cbd4bdf-ddf2-bff0-446f-ce4663c2e5ae"), 2, new Guid("d2807232-4060-4a36-97ff-97d3602c14a7"), 630L, 605L },
                    { new Guid("3d688ebc-0091-39bd-db22-d4472c067918"), 2, new Guid("c6ec4a1a-8d23-c730-ffeb-25a9e655f2fe"), 1740L, 1715L },
                    { new Guid("3e3baff4-7c06-c948-5df8-de1e84a167a7"), 2, new Guid("4c28273b-1c68-47f9-e951-4b25af60b994"), 1620L, 1595L },
                    { new Guid("3e436ccb-a4f5-0fd0-bde4-f4f76ce679cd"), 2, new Guid("c52e968e-9a52-c70d-7d2f-97f88c22bdbb"), 1190L, 1165L },
                    { new Guid("3f2c3857-6d32-ec27-07a2-1cff3f9fd073"), 1, new Guid("f35389e3-d31e-3cb9-32e4-6df93cbe8a3f"), 1930L, 1930L },
                    { new Guid("3f7fc469-9405-0bad-153f-982e92ca7c31"), 1, new Guid("3ce03eb3-0f9e-a093-f328-a5fa7b763833"), 1700L, 1700L },
                    { new Guid("414d7938-9290-7eb4-87e1-49e3f357607b"), 1, new Guid("00c2cb5a-2469-1b5a-1c9c-5dec45703795"), 0L, 0L },
                    { new Guid("41886368-03af-95f8-9aa6-b522ddde8a62"), 2, new Guid("d4be6ec7-da93-6cb6-5d76-9cdbf0c4eb63"), 1270L, 1245L },
                    { new Guid("4197bee5-2385-0d79-80e7-0c3281955ddf"), 2, new Guid("c80ccf8c-82e4-95dc-a4ee-586bd11e06c9"), 1590L, 1565L },
                    { new Guid("41c7ab5e-fd9a-256e-8d9a-f8b8f5310ef7"), 2, new Guid("e1d888b2-b6cf-c80b-0fb2-75bc27bf2673"), 1490L, 1465L },
                    { new Guid("41f319da-2caf-a3ab-cd15-1634c66b548d"), 1, new Guid("65afa446-279a-adff-2e86-ff1006f27c44"), 1620L, 1620L },
                    { new Guid("421e5e35-25c0-98ab-8d9d-62927d112b11"), 2, new Guid("c30814d3-bb97-4a34-7b3e-d226223e1c65"), 1390L, 1365L },
                    { new Guid("428dc100-6d7a-d1f8-c67e-87ea6a72cc70"), 1, new Guid("96eecc1f-f858-df1c-eee4-b54ede86489c"), 740L, 740L },
                    { new Guid("42f83dbe-415d-6adc-1e3f-8f6f2104486e"), 1, new Guid("434f78d6-4b00-059d-562e-7f1200fce396"), 430L, 430L },
                    { new Guid("433bde54-b1e4-e5ef-28af-ce5272963109"), 1, new Guid("3a7eb1c5-294d-35b5-9430-22fea88a0e26"), 780L, 780L },
                    { new Guid("43618ca1-5eb4-0565-8915-b4f83454eee5"), 2, new Guid("c4d944fa-17c6-838e-285e-386144f3e635"), 1650L, 1625L },
                    { new Guid("43cf5bbe-5c53-0a3a-e98e-d5c9c86713cc"), 2, new Guid("f11e4571-fa3f-c11d-437f-d81e07a8c0a6"), 200L, 175L },
                    { new Guid("43d4373d-4f75-6da2-f48f-02fa2d5d1a3b"), 1, new Guid("7786a0e3-c9f9-2958-ddea-1c95e9239e27"), 1040L, 1040L },
                    { new Guid("474505a8-fa88-a60d-b177-989d6c554039"), 2, new Guid("cb8e69e0-97cd-cb71-5993-26c1fb37f93b"), 1610L, 1585L },
                    { new Guid("475e4a32-6ad2-19a3-c220-d392b223a624"), 2, new Guid("d8f2c1b2-22ee-a4f5-96e4-f3ebaaec07f3"), 1540L, 1515L },
                    { new Guid("48892550-6bad-e49d-1f8d-e67d4a05b0df"), 1, new Guid("f00194c0-bd1f-4eed-908d-86a69ab55815"), 1680L, 1680L },
                    { new Guid("48ee7000-fefd-a6e6-3f31-0d265400b11a"), 2, new Guid("f604ec93-484b-46a1-a1a7-97223c2d8387"), 1370L, 1345L },
                    { new Guid("490dccd5-0d74-f308-2c4f-8e41ef60c184"), 2, new Guid("1fdb01a1-1ae7-d326-7621-e779c5983b76"), 860L, 835L },
                    { new Guid("4a39b4e2-4cc5-6e1d-ff7c-ff1c820c4f1c"), 1, new Guid("40cb5017-ce99-922d-f32f-34f3a50f86c9"), 630L, 630L },
                    { new Guid("4ae1d143-0d27-e5e3-5b24-9ca0367167b1"), 1, new Guid("c4e3800c-2c1a-02e9-cf80-fd3116933c5f"), 200L, 200L },
                    { new Guid("4b5ae723-1600-06c2-4b8f-8f231c72139d"), 2, new Guid("ca1ce149-019b-84e9-aa11-f720ccf3b895"), 1950L, 1925L },
                    { new Guid("4be7eb23-4b62-9823-d972-dcc0d5397ec1"), 2, new Guid("d40fe671-4324-db55-3412-ff961b071778"), 710L, 685L },
                    { new Guid("4c49768a-21f8-76ce-ffa7-ba41044d28eb"), 1, new Guid("3dfc83e4-ef66-2e4a-d492-634707a5f323"), 1870L, 1870L },
                    { new Guid("4c9a83b0-d2ef-1b15-6fed-e6ca44e68425"), 2, new Guid("faaceb45-0c82-be16-365f-84e4baf31787"), 60L, 35L },
                    { new Guid("4ca2f75d-3f1b-1a3b-a8c8-cec01bc79ced"), 1, new Guid("1837fb87-8c80-2fe2-3de5-851b7b1c29fb"), 480L, 480L },
                    { new Guid("4cec23b8-57e5-18a6-c455-6338ec6217c2"), 2, new Guid("9d158a53-8136-3d3e-5bdf-06a23fc8f1e3"), 820L, 795L },
                    { new Guid("4d5deaff-5bc2-a8af-d62d-f740705ffb64"), 2, new Guid("413faafd-7393-c8ba-6702-41f07e80acd7"), 1410L, 1385L },
                    { new Guid("4dd5c1b1-73ed-9983-842a-c572327b955a"), 2, new Guid("9d397c3b-242c-8187-5b4a-daaceca70df8"), 110L, 85L },
                    { new Guid("4edaea78-b646-4a49-58d4-f20e946f9ddb"), 1, new Guid("fd7989db-e04e-eac9-5ee9-25a296c84d4b"), 570L, 570L },
                    { new Guid("4f251f90-2375-6f67-64f7-55f573246af5"), 1, new Guid("710a05a6-9f00-3f6e-108c-2eb024aca859"), 890L, 890L },
                    { new Guid("4f7adacd-cb9f-c83e-517d-2993b0d56c4b"), 1, new Guid("fb8c525f-5b67-c464-5dc0-5178182ed972"), 530L, 530L },
                    { new Guid("4fddc3b0-8fbe-76a8-de59-4c56a2e75e92"), 1, new Guid("faaceb45-0c82-be16-365f-84e4baf31787"), 10L, 10L },
                    { new Guid("500e3aa1-e634-0164-f051-743ce3927119"), 2, new Guid("60991c5b-63af-3754-df6f-b7869229070c"), 1440L, 1415L },
                    { new Guid("504c623a-ad0f-f22d-be60-4d211852f77a"), 1, new Guid("de1aabfc-b112-376e-1836-5a49d6eaa77a"), 1500L, 1500L },
                    { new Guid("505aa05b-c0eb-0ef1-a305-6c653b73adf6"), 1, new Guid("e2456da0-f70a-95da-5295-09641e009768"), 1530L, 1530L },
                    { new Guid("51281b8d-19ac-8997-55c5-14cec9d50f73"), 1, new Guid("e6dcb8dc-e53b-890c-7f2f-32e86a694aba"), 1330L, 1330L },
                    { new Guid("518d14b0-18cc-5d54-4f00-23c56ebea4e7"), 2, new Guid("09a9b5ec-4ff1-4557-2900-cf30cb05e9ff"), 1220L, 1195L },
                    { new Guid("51ae08db-c5d0-0af5-a900-2699f92a219e"), 1, new Guid("1c036160-5157-a994-ef07-c4b88323bce2"), 210L, 210L },
                    { new Guid("52e3dac1-1c94-665a-c476-fc49dc160421"), 1, new Guid("44f8cf75-c6c4-84c0-8fff-70f3e8fa344f"), 1470L, 1470L },
                    { new Guid("52f8cd6c-a055-3218-9f54-5e9467165ed8"), 2, new Guid("f333db94-f998-8374-a125-af7d94171270"), 640L, 615L },
                    { new Guid("542fe386-122e-dae7-0d63-33dde88f9dd5"), 2, new Guid("d2e0941d-13d7-3f43-3fff-5521187454b6"), 1130L, 1105L },
                    { new Guid("54f0c2f5-2b65-d5af-886f-4576b2be7222"), 1, new Guid("99cc83a5-fc59-58c5-4314-6010179e7a1d"), 720L, 720L },
                    { new Guid("550c3854-3df9-a431-c183-df07ca3cd7ba"), 1, new Guid("7fb2938f-1e65-c1df-7efb-bd481ec0e4e6"), 1250L, 1250L },
                    { new Guid("551336a8-915b-667e-5c34-446ef139bd42"), 1, new Guid("231ae598-8f0c-387a-6ff7-6981c0859dc6"), 830L, 830L },
                    { new Guid("552b9979-8a88-f3d3-d266-e0fae327907b"), 2, new Guid("2e3e4f1c-cf61-378d-4632-991820965c3a"), 590L, 565L },
                    { new Guid("5580d9f3-75bf-883e-d7da-eeb825e82a18"), 2, new Guid("d8edbb0f-5097-4474-d75c-427cf67531ab"), 1320L, 1295L },
                    { new Guid("55bb493d-87ac-7080-8005-61f54289f31f"), 1, new Guid("cc75fc4e-b195-9dd0-a6c5-eea199d097e0"), 940L, 940L },
                    { new Guid("56aa8c58-decc-bfc8-c53a-db0b84df51c7"), 1, new Guid("96973aa0-108e-ed71-7642-22d2c0cfa55d"), 1950L, 1950L },
                    { new Guid("57027cf4-ede1-e1ee-9b4b-4b3009acf26b"), 2, new Guid("42a48900-b3f5-4490-7746-99a042f69d04"), 70L, 45L },
                    { new Guid("573fc7d1-82c3-bd46-66d5-542ee516b9f6"), 2, new Guid("f3cafa40-5ac7-12ee-8840-19d94d4dd63a"), 410L, 385L },
                    { new Guid("577a2555-fa4e-d1b6-c601-4de2ddaba7b8"), 1, new Guid("a30664a7-6f7c-8e1d-27c3-fe869fac97c3"), 950L, 950L },
                    { new Guid("5a2b3a70-b260-00cd-6caa-9b4c33893a87"), 1, new Guid("34894fa5-c10b-d8f7-b01d-f6c224fde3c3"), 90L, 90L },
                    { new Guid("5b7671ae-d69c-2912-1fb0-d28fe6eebb36"), 1, new Guid("c2587625-f94d-2da2-75e1-ceda5559456c"), 850L, 850L },
                    { new Guid("5d87b020-e6e7-746e-1778-58a3f6acc1a9"), 1, new Guid("6c93d106-2377-ac9f-0f63-cf46de241ecf"), 100L, 100L },
                    { new Guid("5d8d9f20-08ff-e5c0-8305-9b08a649d62b"), 1, new Guid("b92777ca-38f5-a1df-7e27-a0e117be2fcc"), 1030L, 1030L },
                    { new Guid("5dfcdfcb-4c97-d82b-630a-9b1de51eda24"), 2, new Guid("5616eb07-fad2-8657-20a8-a9566a310070"), 340L, 315L },
                    { new Guid("5e39caf3-53ca-074c-0610-45542523aec6"), 1, new Guid("e696ad10-d5c2-0f9e-1631-682ef2de619a"), 620L, 620L },
                    { new Guid("5e9a5c1b-c10d-6545-2c05-a8b10ec703e5"), 1, new Guid("9d397c3b-242c-8187-5b4a-daaceca70df8"), 60L, 60L },
                    { new Guid("5f3fe616-d96f-a1c7-b03e-8dd0a5502551"), 1, new Guid("129ec3fd-827e-c5f7-a954-b0484f45ba38"), 1890L, 1890L },
                    { new Guid("61123c7a-672f-0b35-b827-76a05e1c943d"), 1, new Guid("db9631f1-4e22-52c3-835b-9b614823f479"), 1630L, 1630L },
                    { new Guid("61d4f4f5-c210-f071-81c5-eee76c9b7d5b"), 2, new Guid("19028085-2b9d-8cec-a2be-3d1b74116716"), 2020L, 1995L },
                    { new Guid("63548019-475c-10cb-9004-4b2e1d9c10dd"), 1, new Guid("2a012a34-d935-a6d0-f06c-1d19399a143a"), 1660L, 1660L },
                    { new Guid("64c3ec5a-603a-7b51-7b74-2572f62cbb82"), 2, new Guid("61b6666e-deba-1f88-e6ea-3a0040e3063c"), 570L, 545L },
                    { new Guid("655e2124-a71d-c784-5c28-ae8095dd3e87"), 1, new Guid("1a2a48b9-41df-1b22-6ccd-aea89127d4c8"), 70L, 70L },
                    { new Guid("65983f5a-af88-a8a0-9bb8-d99a630a7cdf"), 1, new Guid("443541d4-e78c-e425-b6df-07be9b0be719"), 1110L, 1110L },
                    { new Guid("670d533b-07e1-517e-a641-ac6977ac8bc2"), 2, new Guid("d77151b7-2509-309a-5e9c-0a9edb34403d"), 520L, 495L },
                    { new Guid("6721c580-2368-496e-7ee8-9f57d3afc1f5"), 1, new Guid("4c28273b-1c68-47f9-e951-4b25af60b994"), 1570L, 1570L },
                    { new Guid("68673161-e83c-47ef-78a8-a37715b068eb"), 2, new Guid("fc01d7b5-55c7-7a4e-3082-762ad9fae1c8"), 190L, 165L },
                    { new Guid("6a839629-4b63-739a-c8f6-6117a386a26c"), 1, new Guid("b58ddcde-644f-1c33-717b-6149c8da020a"), 1060L, 1060L },
                    { new Guid("6b0a0519-1fa8-2ece-bfb8-718197cf9309"), 1, new Guid("3ea37e30-a85c-e1e6-48ff-d8dca022714d"), 1150L, 1150L },
                    { new Guid("6b7fccf9-29e0-c8cc-bdf8-66b965625238"), 2, new Guid("6d7e1561-5a42-3776-e44f-655790382842"), 960L, 935L },
                    { new Guid("6ea487ca-d290-be53-2cbe-d6591981ed2f"), 1, new Guid("c430c395-4493-6c05-b7b4-82e3a62e3d9f"), 690L, 690L },
                    { new Guid("6eb4505f-9e80-9f57-e9c7-119d1975ac63"), 2, new Guid("d57f05d3-986a-8e34-fb0d-1e1cbd3067aa"), 870L, 845L },
                    { new Guid("6ee0aa12-4dd8-8b81-3182-ece7bc94e603"), 1, new Guid("e1d888b2-b6cf-c80b-0fb2-75bc27bf2673"), 1440L, 1440L },
                    { new Guid("717a8adf-5ff9-bf2a-cd6d-d44e05e49264"), 1, new Guid("9aaa47bf-7cfc-b8b2-d24d-3dbb68360b01"), 840L, 840L },
                    { new Guid("7268854c-dc60-de2a-3966-10735241388d"), 2, new Guid("2db7f625-bf32-57ee-1bca-fa0d9f5ff4d9"), 560L, 535L },
                    { new Guid("728d4bcf-ba1f-448c-7d81-d8e0caaef414"), 1, new Guid("0b19c87f-a9ac-1a6a-b60f-81fbeb4f3d16"), 130L, 130L },
                    { new Guid("7468f171-8337-1fe2-955a-93817a0f00e3"), 1, new Guid("c631668b-768f-2f5c-e193-5fe2c33c6714"), 870L, 870L },
                    { new Guid("74bf04f6-5c2c-ab6e-dd8a-a991c16cfdef"), 2, new Guid("507689f8-271b-9360-38bc-88cc0794b001"), 2030L, 2005L },
                    { new Guid("7553067f-d428-1968-c118-f07c5fee4a64"), 1, new Guid("953284b8-b292-e221-6865-1f94aaae8b99"), 1750L, 1750L },
                    { new Guid("75b82bda-f1cc-dd8c-a581-734a4a6a5906"), 2, new Guid("9c036704-bf33-aeaa-3ac3-5d0561026a7f"), 800L, 775L },
                    { new Guid("769aeb05-87a6-b885-b0ee-f2efff41852e"), 1, new Guid("7782cc16-346d-5ae4-27d6-927bdf9a57bf"), 1010L, 1010L },
                    { new Guid("77038801-ffac-9a3d-2f44-295f08a35bbf"), 2, new Guid("70ba4948-9e0e-8593-2fb1-db0f40bd6714"), 2010L, 1985L },
                    { new Guid("77466724-c409-8f05-46a7-08c6cd8c455d"), 1, new Guid("9abddb69-1fd7-1bf6-9028-22a9ed2d2f9d"), 970L, 970L },
                    { new Guid("778130e4-5ef1-55e3-6b8e-deb7f9910823"), 2, new Guid("e78b6e73-65d7-14e5-2c17-8a01610eb906"), 1910L, 1885L },
                    { new Guid("78ff9676-327a-eaef-997f-a7bc45f28c8e"), 2, new Guid("9a86c369-6b0c-b985-fd4d-1e5d21e2a81e"), 840L, 815L },
                    { new Guid("790ff1fb-40e5-5ebf-1e0f-9f574acd1255"), 2, new Guid("44f8cf75-c6c4-84c0-8fff-70f3e8fa344f"), 1520L, 1495L },
                    { new Guid("795dc322-dc43-2f99-b419-5ceb14b35bf2"), 1, new Guid("15151b02-a2a7-09af-b508-6ed76e1df2e8"), 500L, 500L },
                    { new Guid("79e9c451-f65a-7682-1d59-ad94582647a1"), 1, new Guid("0e5618f9-a4ce-9337-9179-a58be10c7e96"), 1800L, 1800L },
                    { new Guid("7a6c56f6-007b-1007-17bc-4cc266d03384"), 1, new Guid("e5e243df-c4b1-d035-d4da-bf71451be3c2"), 1310L, 1310L },
                    { new Guid("7b38e775-6c72-6969-653a-0d7b276501a0"), 2, new Guid("107faa47-862d-1686-64ec-36bcd8eaa706"), 1040L, 1015L },
                    { new Guid("7baae726-cb74-e848-6c34-e68696cd1637"), 2, new Guid("69c42663-340d-2452-e12b-8a711e1f712a"), 90L, 65L },
                    { new Guid("7d5a2220-9e43-0a7c-fb33-31935afbc27c"), 2, new Guid("de1aabfc-b112-376e-1836-5a49d6eaa77a"), 1550L, 1525L },
                    { new Guid("7d8f9466-21e5-cdf3-770a-b09e24533dd8"), 1, new Guid("9c6b938a-ae21-1704-6684-d9448e307263"), 1400L, 1400L },
                    { new Guid("7db94883-f9ba-16a8-0c0d-cc32b16f9f7c"), 2, new Guid("b58ddcde-644f-1c33-717b-6149c8da020a"), 1110L, 1085L },
                    { new Guid("7dcf2cef-8a53-8c46-1e19-b9a607a53c28"), 1, new Guid("21a97a27-a9e9-7cfa-1950-beb9a1d11212"), 1580L, 1580L },
                    { new Guid("7e88a6c7-b353-5fa7-5705-ee5e5b6a4bff"), 1, new Guid("d2e0941d-13d7-3f43-3fff-5521187454b6"), 1080L, 1080L },
                    { new Guid("7e8f32ff-ad95-c6a5-b1ad-2d2e317cf27b"), 1, new Guid("c6ec4a1a-8d23-c730-ffeb-25a9e655f2fe"), 1690L, 1690L },
                    { new Guid("7eb9696a-294c-1965-f10d-71a284e6acc0"), 1, new Guid("69c42663-340d-2452-e12b-8a711e1f712a"), 40L, 40L },
                    { new Guid("7ee41d79-0594-634f-db8b-6d282c831e4a"), 1, new Guid("d8f2c1b2-22ee-a4f5-96e4-f3ebaaec07f3"), 1490L, 1490L },
                    { new Guid("80114c8c-6dc5-c860-bc32-0d96976047a8"), 2, new Guid("666cf265-4716-9899-9112-b85ba718d6e0"), 810L, 785L },
                    { new Guid("82806811-ec03-dfbe-a029-f56a0f980c1c"), 2, new Guid("f00194c0-bd1f-4eed-908d-86a69ab55815"), 1730L, 1705L },
                    { new Guid("83e14578-6d36-635e-093a-9abd25ca97e6"), 2, new Guid("3d24d818-ca52-ff8f-8929-3ae4e072f6ca"), 1760L, 1735L },
                    { new Guid("848b86ef-dc3d-40b6-57c6-37a3d579f5c0"), 1, new Guid("5121ec2a-aa0e-861f-e169-52232ba0f413"), 1920L, 1920L },
                    { new Guid("85109495-f35a-82d2-7519-fc0a2314f131"), 1, new Guid("4a86e21d-0989-48fc-1581-554b77eadbee"), 1520L, 1520L },
                    { new Guid("85599cf1-6ed5-5003-5c99-9f1661f548ca"), 2, new Guid("1837fb87-8c80-2fe2-3de5-851b7b1c29fb"), 530L, 505L },
                    { new Guid("85ebd5d9-e73f-adaa-c2d8-b3c7befc58b7"), 2, new Guid("96973aa0-108e-ed71-7642-22d2c0cfa55d"), 2000L, 1975L },
                    { new Guid("8731875b-41a0-dfac-ebcd-5deaf7048f3f"), 2, new Guid("65afa446-279a-adff-2e86-ff1006f27c44"), 1670L, 1645L },
                    { new Guid("8876c90f-853c-13a7-4232-a31be550913a"), 2, new Guid("e39df5dd-e61e-c4f5-5f15-ed7c6f98c697"), 750L, 725L },
                    { new Guid("88a1b846-d721-490c-b683-f47ef91f4d63"), 2, new Guid("9abddb69-1fd7-1bf6-9028-22a9ed2d2f9d"), 1020L, 995L },
                    { new Guid("88b161e4-3f34-fd29-1002-e01ce8a70c42"), 1, new Guid("a9f6a116-b1b0-9031-78c8-e20b4fcd62af"), 1300L, 1300L },
                    { new Guid("88e45c03-3408-3270-78bf-e4a367470b09"), 1, new Guid("4481b838-e954-dd1e-9fa6-3b0690f98c5d"), 1380L, 1380L },
                    { new Guid("88fc25f5-104b-f4d2-c4fc-085fcb7caecb"), 2, new Guid("16238310-1257-db51-e212-02975fca2cc2"), 440L, 415L },
                    { new Guid("8955bbf6-8eeb-a3cd-f072-029b88b62d04"), 2, new Guid("14b38d22-8237-bfb5-de0c-7c2d95f9b2b9"), 1560L, 1535L },
                    { new Guid("8a0f5991-a3a1-ac77-3885-a976e510a1f0"), 2, new Guid("443541d4-e78c-e425-b6df-07be9b0be719"), 1160L, 1135L },
                    { new Guid("8a12afab-3914-4a65-6f03-61d65c7fa21e"), 1, new Guid("28fd3600-8963-7f02-6eae-68f89d0f4cb7"), 960L, 960L },
                    { new Guid("8c189099-b9c5-031a-2885-429612e6cd85"), 2, new Guid("434f78d6-4b00-059d-562e-7f1200fce396"), 480L, 455L },
                    { new Guid("8c333547-2394-e329-e26e-fca79d19e712"), 2, new Guid("0470a4de-e475-cc94-b72d-17da8f14672d"), 1420L, 1395L },
                    { new Guid("8ce9e348-6df5-f2d2-72cc-5623fac3b970"), 2, new Guid("1d8f562e-029b-d558-72f8-2264d5a86178"), 1990L, 1965L },
                    { new Guid("8d1456b7-7052-ce83-577d-f3c8d5324262"), 2, new Guid("4a86e21d-0989-48fc-1581-554b77eadbee"), 1570L, 1545L },
                    { new Guid("8d908e4d-90f7-2bf7-8a6e-adc7830d8cc7"), 1, new Guid("99508c9a-4ef4-2e19-86aa-c72da0c95990"), 280L, 280L },
                    { new Guid("8dc0805d-a1de-c0a2-203f-80b3dc146fe2"), 1, new Guid("6d7e1561-5a42-3776-e44f-655790382842"), 910L, 910L },
                    { new Guid("8ddebd05-d403-3b8e-5227-ae6239b9fdb5"), 2, new Guid("4d2d36c5-a588-e435-6804-56f474a790be"), 1150L, 1125L },
                    { new Guid("8ed4c20d-6dc4-3709-8096-4e6b4adb0993"), 2, new Guid("2d6edfdf-09e6-aa11-6830-18fc36b9d43c"), 390L, 365L },
                    { new Guid("8ee51adc-5e28-2eef-30c9-8d0fbfac7505"), 1, new Guid("34cf2c3b-e6a2-816d-2e44-ccbecfd0be17"), 1610L, 1610L },
                    { new Guid("8f9935c1-45c5-9991-0238-03181038aba2"), 2, new Guid("9e3990c7-7634-af3b-eef7-23a8117e4beb"), 1900L, 1875L },
                    { new Guid("8fd54135-de30-aa06-de45-1ed5d795ce67"), 2, new Guid("8e41fa3e-863f-e902-6907-7660401a7de6"), 360L, 335L },
                    { new Guid("902b3626-c72c-b4e3-7807-0da50cdbd0c5"), 2, new Guid("fbd3278e-fd98-690d-a67c-a88f575a80fe"), 240L, 215L },
                    { new Guid("903811f4-930c-808a-851e-c79be9c52455"), 2, new Guid("d6c20696-a5af-bd1f-a61c-f0f552fb8287"), 1860L, 1835L },
                    { new Guid("90e16014-6448-8816-a0e7-923ff5bacc47"), 2, new Guid("28fd3600-8963-7f02-6eae-68f89d0f4cb7"), 1010L, 985L },
                    { new Guid("90f8e6f7-4e34-c3af-981f-ac578d341f9e"), 2, new Guid("d66dd9fc-8734-870d-d07c-082b0103f016"), 1310L, 1285L },
                    { new Guid("912bc3b6-4bb8-5284-c889-163fae7d21b1"), 2, new Guid("91917c7b-b6d9-bbd0-2d18-57c0974af437"), 1530L, 1505L },
                    { new Guid("912ceb8c-d7a6-7a25-4437-a57a306e5721"), 1, new Guid("4d2d36c5-a588-e435-6804-56f474a790be"), 1100L, 1100L },
                    { new Guid("91ed21aa-db53-8e0b-4d5d-1e4698437b9a"), 1, new Guid("f4e0c2f2-b82d-855e-4d13-4020bec28906"), 1020L, 1020L },
                    { new Guid("926f4f28-d01e-7141-6507-6d433c485194"), 1, new Guid("2c50b4c2-a5d8-b806-68df-532fa7c6ec98"), 610L, 610L },
                    { new Guid("927eb942-0b5b-2e7b-c8fe-a37e12a865a8"), 2, new Guid("4cca7a30-69a1-a3ae-8b72-23f3e93db1a7"), 460L, 435L },
                    { new Guid("9386d52a-043f-b300-e992-f23e33d1ba96"), 1, new Guid("0dfa902a-c2a8-8f93-c30e-ed531be36158"), 1160L, 1160L },
                    { new Guid("93e0f596-9955-74ce-2443-05576d3c29f6"), 2, new Guid("ef938078-0e91-ba82-1135-c26daadf1992"), 1460L, 1435L },
                    { new Guid("94e04178-3409-c9a1-0cfa-e0dad3230023"), 1, new Guid("64d28203-26be-91a8-21a4-d7258552e00a"), 650L, 650L },
                    { new Guid("9553638c-17d4-3e57-76b0-c99f44317900"), 2, new Guid("d25ae26b-9a99-2bf5-a0ec-c4abf10e8f36"), 1890L, 1865L },
                    { new Guid("95df1dcb-1e19-8b65-d152-c1fe3afc5ef7"), 2, new Guid("43973915-90be-5c06-56dd-9485c346c629"), 490L, 465L },
                    { new Guid("96232c67-3879-4731-9cf0-0cc84cb369bd"), 2, new Guid("3a7eb1c5-294d-35b5-9430-22fea88a0e26"), 830L, 805L },
                    { new Guid("963e618b-3022-72b4-819f-dd9180f11b1a"), 2, new Guid("1c036160-5157-a994-ef07-c4b88323bce2"), 260L, 235L },
                    { new Guid("97b6751e-cdf3-a0ac-5b3b-bf43b2c8b982"), 1, new Guid("d77151b7-2509-309a-5e9c-0a9edb34403d"), 470L, 470L },
                    { new Guid("98874e4b-928b-6964-a89b-6697cd8e39a6"), 2, new Guid("0fb3e3e5-97ca-9ab9-b369-64df63169ddd"), 510L, 485L },
                    { new Guid("993485e0-411a-202e-8602-6f472d1bdbc9"), 1, new Guid("666cf265-4716-9899-9112-b85ba718d6e0"), 760L, 760L },
                    { new Guid("99c677f5-ceb1-cf2d-3a21-b39fe603eaf7"), 2, new Guid("96eecc1f-f858-df1c-eee4-b54ede86489c"), 790L, 765L },
                    { new Guid("9a54093c-0e8e-c46e-66b2-525b611d7e24"), 2, new Guid("b307f16b-a703-0fca-36e3-9ed0637db79e"), 1720L, 1695L },
                    { new Guid("9a61b6d6-bb4b-293d-8b44-4f1d0ec2a57c"), 1, new Guid("5616eb07-fad2-8657-20a8-a9566a310070"), 290L, 290L },
                    { new Guid("9a8f2442-87bc-e654-4047-336d699e8754"), 2, new Guid("e60739fc-9638-cd5b-aaba-4713f9c9bf13"), 610L, 585L },
                    { new Guid("9ad88df6-5bb4-8cfe-da2a-8dbff9b54c52"), 1, new Guid("8e41fa3e-863f-e902-6907-7660401a7de6"), 310L, 310L },
                    { new Guid("9ade08e2-30b7-a16b-52db-5b33bdf09c08"), 2, new Guid("129ec3fd-827e-c5f7-a954-b0484f45ba38"), 1940L, 1915L },
                    { new Guid("9b2cf3fc-f03f-3892-8056-bf8871820cbe"), 2, new Guid("c2559da7-256b-eeb7-9782-30075b0a95a5"), 1250L, 1225L },
                    { new Guid("9b72b6ef-51eb-9bab-de5e-9566050927ab"), 1, new Guid("c233339a-ab6a-ac2a-a854-2dcaf17b8307"), 270L, 270L },
                    { new Guid("9df88b8d-9531-0567-6f6e-6786458bb6b0"), 1, new Guid("44e9379e-1450-e3c1-e9b9-64423b924d07"), 1000L, 1000L },
                    { new Guid("9e4fc22b-8fef-2017-ad7c-677a08cfe10a"), 2, new Guid("0b19c87f-a9ac-1a6a-b60f-81fbeb4f3d16"), 180L, 155L },
                    { new Guid("9e5187a8-a249-283f-842f-ace382f6b387"), 2, new Guid("e7589363-cbd4-89c8-5361-af71cce01a4b"), 350L, 325L },
                    { new Guid("9efead15-44db-155c-33a1-fd83412ab3ca"), 1, new Guid("cb8e69e0-97cd-cb71-5993-26c1fb37f93b"), 1560L, 1560L },
                    { new Guid("a029014f-2be7-a6e4-7ebd-f968e5bc527c"), 1, new Guid("16238310-1257-db51-e212-02975fca2cc2"), 390L, 390L },
                    { new Guid("a02960b9-ad8b-b06c-aea5-dc0480510c37"), 2, new Guid("3035d2fc-b171-a5e0-c842-fb7c36f237f9"), 1340L, 1315L },
                    { new Guid("a05551c1-48b1-15b0-e8f6-c2994e5ca3d8"), 2, new Guid("41c4b5aa-6dea-c363-4d42-5659947a3cb2"), 1240L, 1215L },
                    { new Guid("a0c832a7-7d0e-ffd7-9d67-0c330485fb5c"), 1, new Guid("61b6666e-deba-1f88-e6ea-3a0040e3063c"), 520L, 520L },
                    { new Guid("a0edb419-56de-4e51-f3fc-8bf81897c826"), 2, new Guid("db9631f1-4e22-52c3-835b-9b614823f479"), 1680L, 1655L },
                    { new Guid("a13689c6-3a25-6031-b9ff-34edff71fa05"), 1, new Guid("9a86c369-6b0c-b985-fd4d-1e5d21e2a81e"), 790L, 790L },
                    { new Guid("a23a9ed4-612a-3692-52f6-611d7c409526"), 1, new Guid("d57f05d3-986a-8e34-fb0d-1e1cbd3067aa"), 820L, 820L },
                    { new Guid("a4a34be5-6ed9-bb78-fd34-76bdc008d710"), 1, new Guid("e99f14f7-4e48-119e-536f-b488c18f3448"), 1090L, 1090L },
                    { new Guid("a4e8a0b8-c2fb-75bd-f65b-0e713663d3f3"), 1, new Guid("7da9f293-4b0a-b878-4ddc-e9f6a9d10940"), 730L, 730L },
                    { new Guid("a545a355-d638-bcaf-70d7-fc69be5ef39c"), 1, new Guid("e60739fc-9638-cd5b-aaba-4713f9c9bf13"), 560L, 560L },
                    { new Guid("a68dad80-0f80-da2d-b929-e1b2676f4ae6"), 1, new Guid("38dfac91-2f97-00c2-6b00-3dab16e71f67"), 1420L, 1420L },
                    { new Guid("a6a91b4b-4264-21d0-15e9-cb47ec3c8e86"), 1, new Guid("7ce2d7bd-cd53-4988-1e9d-d23d6b325edd"), 1350L, 1350L },
                    { new Guid("a89d299b-1beb-4523-0ba8-8042e9fdedfb"), 2, new Guid("df949aa7-214c-c52f-e0cf-302c97c0ca75"), 80L, 55L },
                    { new Guid("a98827b8-5eb4-5f68-9237-6083fd6cbc3a"), 2, new Guid("9aaa47bf-7cfc-b8b2-d24d-3dbb68360b01"), 890L, 865L },
                    { new Guid("aa575d69-0cc7-4955-6deb-08d102590044"), 2, new Guid("3ce03eb3-0f9e-a093-f328-a5fa7b763833"), 1750L, 1725L },
                    { new Guid("ab9e0be4-6d37-4951-a5cb-208305e0dd00"), 1, new Guid("f333db94-f998-8374-a125-af7d94171270"), 590L, 590L },
                    { new Guid("ab9e57ef-6080-9376-541d-104098354a87"), 1, new Guid("41c4b5aa-6dea-c363-4d42-5659947a3cb2"), 1190L, 1190L },
                    { new Guid("abf20486-17c6-e186-1248-f26c81758061"), 2, new Guid("21a97a27-a9e9-7cfa-1950-beb9a1d11212"), 1630L, 1605L },
                    { new Guid("ac1db940-634c-6a11-6d59-e95f9f79fe49"), 2, new Guid("29ee8664-1a25-e8d9-6275-69db69c05782"), 370L, 345L },
                    { new Guid("acd3d35a-8f68-b4c0-d85c-54b997994e34"), 2, new Guid("3a5908c6-a9a1-6fe5-14bd-3e24be71e64c"), 160L, 135L },
                    { new Guid("acdfd5cb-e22c-88d5-86bf-6550b6d1a8e1"), 1, new Guid("91917c7b-b6d9-bbd0-2d18-57c0974af437"), 1480L, 1480L },
                    { new Guid("ad4be044-2796-4174-fde8-bd8144752834"), 2, new Guid("85f73e5d-db6d-4568-0134-3b27a4062c34"), 1500L, 1475L },
                    { new Guid("ae7288f2-bdba-c49a-bd7a-abe65701a1dc"), 1, new Guid("0f3fb9be-1be2-721b-fdd6-b1dbc6a90957"), 80L, 80L },
                    { new Guid("af4e32ef-efdc-1c0f-2888-67d24e894980"), 2, new Guid("6c93d106-2377-ac9f-0f63-cf46de241ecf"), 150L, 125L },
                    { new Guid("b17dba13-e9b8-cb27-5e3d-f5b3d19c2fe5"), 1, new Guid("7737b8b9-2996-bfdd-1727-4ac61d100a6a"), 670L, 670L },
                    { new Guid("b3bb70a1-0251-22ef-7724-2f8c080921f8"), 2, new Guid("bea2ceec-11f1-521a-a0bd-7711598e3cba"), 1770L, 1745L },
                    { new Guid("b3ef519f-4643-771c-b791-bcdff75fc7a5"), 2, new Guid("b92777ca-38f5-a1df-7e27-a0e117be2fcc"), 1080L, 1055L },
                    { new Guid("b4a71e91-a5bf-b509-8b06-fcd98f9ebbc3"), 2, new Guid("e99f14f7-4e48-119e-536f-b488c18f3448"), 1140L, 1115L },
                    { new Guid("b5554aa4-b648-b588-569c-3d7b00087088"), 1, new Guid("bea2ceec-11f1-521a-a0bd-7711598e3cba"), 1720L, 1720L },
                    { new Guid("b5b8a821-b9c8-08f8-c70c-7a88a1b1296d"), 1, new Guid("e7589363-cbd4-89c8-5361-af71cce01a4b"), 300L, 300L },
                    { new Guid("b5ed09dc-6583-65b5-0943-7d86331b1879"), 2, new Guid("c430c395-4493-6c05-b7b4-82e3a62e3d9f"), 740L, 715L },
                    { new Guid("b68717a2-df1d-50df-9b6a-475dfcbcf130"), 1, new Guid("42a48900-b3f5-4490-7746-99a042f69d04"), 20L, 20L },
                    { new Guid("b6d2504b-3df7-8804-cc01-3f3936ca8318"), 1, new Guid("a63febd7-8649-e66f-40b3-12bffa111fb9"), 180L, 180L },
                    { new Guid("b6ea6230-2352-3938-2634-704435b9daae"), 1, new Guid("60991c5b-63af-3754-df6f-b7869229070c"), 1390L, 1390L },
                    { new Guid("b953f7e0-5fa6-b286-2fa7-9f0e0a346f3c"), 2, new Guid("f35389e3-d31e-3cb9-32e4-6df93cbe8a3f"), 1980L, 1955L },
                    { new Guid("b95d5317-7d16-a7e2-0cab-3894be534802"), 1, new Guid("1f868a0c-6ee9-47ab-3372-b3ac9dc69c3d"), 1830L, 1830L },
                    { new Guid("b9ddac31-5c73-1c8c-4378-2f9e83f174a4"), 2, new Guid("231ae598-8f0c-387a-6ff7-6981c0859dc6"), 880L, 855L },
                    { new Guid("ba21ac80-72a6-d6d7-66ad-ecf6f690e363"), 1, new Guid("70ba4948-9e0e-8593-2fb1-db0f40bd6714"), 1960L, 1960L },
                    { new Guid("bb0706b9-6bab-2e05-7f51-04779969b931"), 2, new Guid("17f499fb-93b1-ac0d-d49e-1b16f66c2084"), 450L, 425L },
                    { new Guid("bb238bc5-1580-980f-1e02-c933390b27ee"), 2, new Guid("0e5618f9-a4ce-9337-9179-a58be10c7e96"), 1850L, 1825L },
                    { new Guid("bb52f140-dc6f-cc28-645a-3bf5b2d8638f"), 1, new Guid("507689f8-271b-9360-38bc-88cc0794b001"), 1980L, 1980L },
                    { new Guid("bbc44fdd-99f7-a808-368e-8c9321b523ca"), 2, new Guid("3f105459-7ce8-9c0b-3968-571476428150"), 420L, 395L },
                    { new Guid("bbd920b1-7a6e-d89a-265f-dd702fe947fd"), 2, new Guid("710a05a6-9f00-3f6e-108c-2eb024aca859"), 940L, 915L },
                    { new Guid("bc84d7b2-4abb-751c-6fb6-4f525acd82ab"), 2, new Guid("c2587625-f94d-2da2-75e1-ceda5559456c"), 900L, 875L },
                    { new Guid("bf1cd5ac-a407-0302-5d52-a0da74061124"), 1, new Guid("7b37db38-4364-2701-1883-6d94623546ea"), 170L, 170L },
                    { new Guid("bfa37299-0893-bd82-f5c4-811f35f15789"), 2, new Guid("1a2a48b9-41df-1b22-6ccd-aea89127d4c8"), 120L, 95L },
                    { new Guid("c025ca2d-7551-dbda-89c3-8ee05ebf5747"), 1, new Guid("cba75903-7e3e-cc4d-9e89-01ce3a4e8912"), 250L, 250L },
                    { new Guid("c0b91164-cd21-530b-2c7f-6b04d397795d"), 1, new Guid("43973915-90be-5c06-56dd-9485c346c629"), 440L, 440L },
                    { new Guid("c0d2d3af-2275-d5f8-666b-2ebe329bb49e"), 2, new Guid("674a5b79-5846-9bb3-2143-320816452523"), 270L, 245L },
                    { new Guid("c17a11df-6b4e-9955-fce8-2361035f0a5f"), 2, new Guid("13dfca12-6a42-0cef-59d8-507164cce32f"), 380L, 355L },
                    { new Guid("c1bd22fa-49b4-5ca8-91fc-6ea90ca4231c"), 2, new Guid("53784a22-a8e6-8148-39c1-0a86fd447266"), 1120L, 1095L },
                    { new Guid("c3934e84-87d5-7dd3-fd62-bea5e97df5a3"), 2, new Guid("c39f5a72-d208-ea5e-8c7d-602caa143cf9"), 1030L, 1005L },
                    { new Guid("c3957dd0-5844-a926-5720-d05cce47da13"), 2, new Guid("eb2e251b-8c1c-78d0-f7cb-002d49330f9a"), 910L, 885L },
                    { new Guid("c3d621d8-64c3-6d1b-7244-7b27d13214a6"), 1, new Guid("24c835e2-de12-eac4-6b25-d692546b46c1"), 160L, 160L },
                    { new Guid("c40b7a24-be54-13fc-3a8c-6f4fb019041a"), 1, new Guid("cc51157a-1595-4c33-afd0-7397bd34f462"), 1880L, 1880L },
                    { new Guid("c4b71877-3268-180d-9170-81401c8b7a2f"), 1, new Guid("602604b0-f2b9-7927-d12a-b2e8746119f8"), 350L, 350L },
                    { new Guid("c4dd8023-856b-0ce4-ed63-5761b5d884d2"), 1, new Guid("b7fced86-fec2-906c-d286-86124156f077"), 1780L, 1780L },
                    { new Guid("c5843886-55d1-2415-41bb-0ae069048e30"), 2, new Guid("dfdc9bd4-45d7-2a66-feb1-faa6989aaa88"), 850L, 825L },
                    { new Guid("c62b7dea-7927-344a-ed75-5e74a8f2625a"), 1, new Guid("2555c940-3884-f262-627e-7fbcb3009c88"), 1050L, 1050L },
                    { new Guid("c6872089-cbd8-6f43-5b0d-026c9590d825"), 2, new Guid("cf0323e5-496c-5eaa-1f70-16742ca7708e"), 1260L, 1235L },
                    { new Guid("c6d9f890-f62d-a917-285b-f6f91da60428"), 1, new Guid("170f2038-72a4-761b-a5d5-1ac10959d5ca"), 380L, 380L },
                    { new Guid("c720d6db-1495-e1db-f5a3-f2a9e8bfbd1d"), 1, new Guid("19028085-2b9d-8cec-a2be-3d1b74116716"), 1970L, 1970L },
                    { new Guid("c7ab91d5-31e0-bbc6-8e18-0835925288aa"), 2, new Guid("cba75903-7e3e-cc4d-9e89-01ce3a4e8912"), 300L, 275L },
                    { new Guid("c9134035-900a-cd57-d1d0-33ba529bd2e1"), 2, new Guid("7da9f293-4b0a-b878-4ddc-e9f6a9d10940"), 780L, 755L },
                    { new Guid("c9c0f78e-2c3e-8a8d-de6d-27e63d44be76"), 1, new Guid("ddb9c3cc-b3fe-707f-f885-7f93bf37030d"), 1790L, 1790L },
                    { new Guid("c9e575b3-1455-078b-c2ce-70e6b565acd6"), 2, new Guid("3ea37e30-a85c-e1e6-48ff-d8dca022714d"), 1200L, 1175L },
                    { new Guid("c9f2a040-fbb8-a125-84d7-5ed1c4af7be5"), 1, new Guid("863e291c-d1a1-a10c-42a9-4bfc5650861c"), 1740L, 1740L },
                    { new Guid("ca19f1bd-07a7-8e1b-c9fe-a68b771c57eb"), 1, new Guid("c355826f-8291-bf60-1b35-ba7323f13226"), 450L, 450L },
                    { new Guid("ca97897f-a42b-b149-b4ae-3d9f4a21c6cb"), 1, new Guid("1fdb01a1-1ae7-d326-7621-e779c5983b76"), 810L, 810L },
                    { new Guid("cad42b03-a2b8-1c79-6476-8de6677bf47d"), 2, new Guid("303d389d-2832-a934-3cf2-93f29f9dd2b2"), 1510L, 1485L },
                    { new Guid("cb86052b-56d6-3033-5d13-8dbfaf33e0bb"), 2, new Guid("5cf87699-cf68-636c-08ae-42806dfe7292"), 930L, 905L },
                    { new Guid("ccb9dfb5-435c-4b2f-42d6-fd3a8d625591"), 1, new Guid("8d602441-288d-a27e-ce6a-c64495b24acb"), 920L, 920L },
                    { new Guid("ce1276a8-aa6c-abf0-a678-8bad12d3c2c6"), 2, new Guid("7115bae7-a9b2-b31b-8f98-f3d5b4f3c221"), 1780L, 1755L },
                    { new Guid("cef99144-f1c7-7df0-7478-5cffbf9a52c1"), 1, new Guid("eb2e251b-8c1c-78d0-f7cb-002d49330f9a"), 860L, 860L },
                    { new Guid("cfc163d9-3701-b26c-c50a-254d870f147c"), 1, new Guid("f13a1a86-937f-68e0-4060-52fd3715a9d8"), 1990L, 1990L },
                    { new Guid("d1a8bc5c-8240-c493-d328-eb49e416720c"), 2, new Guid("ee72f412-8473-7247-f7c1-c5c0285464e4"), 650L, 625L },
                    { new Guid("d26c59f8-4fa2-8c6e-e925-d63268c1f534"), 2, new Guid("7ce2d7bd-cd53-4988-1e9d-d23d6b325edd"), 1400L, 1375L },
                    { new Guid("d2974373-060d-cfed-9518-024e2f6c91e7"), 2, new Guid("0dfa902a-c2a8-8f93-c30e-ed531be36158"), 1210L, 1185L },
                    { new Guid("d2cb5bb6-4906-a252-7e27-47cdee442843"), 1, new Guid("3035d2fc-b171-a5e0-c842-fb7c36f237f9"), 1290L, 1290L },
                    { new Guid("d2d4a3a3-d729-efc0-b776-8f5dd2f59ae8"), 1, new Guid("7115bae7-a9b2-b31b-8f98-f3d5b4f3c221"), 1730L, 1730L },
                    { new Guid("d2f6d284-8e95-96b8-d3a6-714f52b114ec"), 1, new Guid("85f73e5d-db6d-4568-0134-3b27a4062c34"), 1450L, 1450L },
                    { new Guid("d440d969-7076-e4b1-2478-40ca7ca4b3d4"), 2, new Guid("8d0d96c6-31e0-7cf6-2072-191e0d6b5cf1"), 1170L, 1145L },
                    { new Guid("d5333915-c60f-fc87-4009-220bcb26e532"), 1, new Guid("d25ae26b-9a99-2bf5-a0ec-c4abf10e8f36"), 1840L, 1840L },
                    { new Guid("d554cdc4-d384-5355-6a14-267d6458b2c9"), 2, new Guid("f670d4ae-7755-984e-3a49-f0896bd50790"), 600L, 575L },
                    { new Guid("d5f45410-74ef-9356-9281-0c5ad9f5033f"), 2, new Guid("4e411548-2788-eea3-650a-5b76eb7063f7"), 760L, 735L },
                    { new Guid("d693a00a-5b73-754a-dbb7-c6634518c042"), 2, new Guid("f4e0c2f2-b82d-855e-4d13-4020bec28906"), 1070L, 1045L },
                    { new Guid("d7473352-63e5-ed74-28c7-10b30c8a4852"), 1, new Guid("d8edbb0f-5097-4474-d75c-427cf67531ab"), 1270L, 1270L },
                    { new Guid("d74be5fa-5ace-cced-0413-c6c1472b44fd"), 1, new Guid("4cca7a30-69a1-a3ae-8b72-23f3e93db1a7"), 410L, 410L },
                    { new Guid("d854b8e4-156b-9ea1-b1eb-93cfb64705b4"), 2, new Guid("863e291c-d1a1-a10c-42a9-4bfc5650861c"), 1790L, 1765L },
                    { new Guid("d85e7f13-2cec-ff65-1148-962702e594bb"), 1, new Guid("b307f16b-a703-0fca-36e3-9ed0637db79e"), 1670L, 1670L },
                    { new Guid("dc0885f9-6d4b-a9f8-3302-a39f5b042933"), 2, new Guid("28058790-f46a-ec31-086b-d564b402596e"), 1480L, 1455L },
                    { new Guid("dd15499f-6ab6-d856-1844-25f37c6be80c"), 2, new Guid("988ea22f-2615-f10a-b166-e5e6ff93d773"), 1820L, 1795L },
                    { new Guid("ddb5c26b-bb0c-025a-4381-056dda259b44"), 2, new Guid("a30664a7-6f7c-8e1d-27c3-fe869fac97c3"), 1000L, 975L },
                    { new Guid("dea79594-db74-4f5a-9ec6-d7d64cd253dc"), 2, new Guid("aee54e20-f5b0-1657-8b93-b72c02d9c8e3"), 310L, 285L },
                    { new Guid("df97bd76-140c-e11e-13af-ea4d31465866"), 1, new Guid("d2807232-4060-4a36-97ff-97d3602c14a7"), 580L, 580L },
                    { new Guid("e01d163e-a94c-15f7-ecd8-9b590991dc4a"), 1, new Guid("d40fe671-4324-db55-3412-ff961b071778"), 660L, 660L },
                    { new Guid("e042ecb0-13c3-76ea-3367-6c8822f1dd81"), 2, new Guid("7786a0e3-c9f9-2958-ddea-1c95e9239e27"), 1090L, 1065L },
                    { new Guid("e09e3a71-60f8-b9e7-8fa8-b8a695c66fce"), 2, new Guid("44e9379e-1450-e3c1-e9b9-64423b924d07"), 1050L, 1025L },
                    { new Guid("e2abe0b4-83f2-29b9-37fd-31fc7ed42234"), 2, new Guid("7b37db38-4364-2701-1883-6d94623546ea"), 220L, 195L },
                    { new Guid("e3c531c8-7fc4-f39d-3800-c41fcfcff461"), 1, new Guid("107faa47-862d-1686-64ec-36bcd8eaa706"), 990L, 990L },
                    { new Guid("e3f23dcf-6187-1c93-47b9-cdf8da46a624"), 2, new Guid("c9829083-d68f-509d-7335-6f85e46046e0"), 1960L, 1935L },
                    { new Guid("e52e4949-ec58-b9ba-ce10-76c6a18159b7"), 2, new Guid("e512b5f7-d2c7-7bbb-d976-9c228b83abe9"), 1640L, 1615L },
                    { new Guid("e53d8b5e-97db-2547-6f08-5e58dc0eddd7"), 2, new Guid("5b9721b8-da76-9046-9773-149c207231f3"), 290L, 265L },
                    { new Guid("e5563972-54d3-9501-8d83-89b92d0181f6"), 1, new Guid("2d6edfdf-09e6-aa11-6830-18fc36b9d43c"), 340L, 340L },
                    { new Guid("e572a812-d1a6-db37-cb43-b8d5ea12c6a8"), 2, new Guid("8f925157-7f45-11a5-d22d-75a235faa9bc"), 690L, 665L },
                    { new Guid("e5a466db-041a-423a-176a-f8ae55e04281"), 1, new Guid("4d4d57f8-4a7e-ce70-50e9-e442031a3f50"), 1240L, 1240L },
                    { new Guid("e657bc34-665e-e4fa-4416-b119a2bafe65"), 1, new Guid("c9829083-d68f-509d-7335-6f85e46046e0"), 1910L, 1910L },
                    { new Guid("e6ca9940-e233-aef9-ac71-63cc143862ec"), 2, new Guid("4481b838-e954-dd1e-9fa6-3b0690f98c5d"), 1430L, 1405L },
                    { new Guid("e7508501-f96c-2732-1b8b-a04fdc0fa5b4"), 1, new Guid("d4be6ec7-da93-6cb6-5d76-9cdbf0c4eb63"), 1220L, 1220L },
                    { new Guid("e9f5d24a-8cc6-41cd-f82c-4bca6d82c6e7"), 2, new Guid("a9f6a116-b1b0-9031-78c8-e20b4fcd62af"), 1350L, 1325L },
                    { new Guid("eb0e562c-703b-758f-a578-eb35e36dc536"), 2, new Guid("cc75fc4e-b195-9dd0-a6c5-eea199d097e0"), 990L, 965L },
                    { new Guid("ec08d5b3-5449-5e39-2e3e-8a3726f36212"), 1, new Guid("28058790-f46a-ec31-086b-d564b402596e"), 1430L, 1430L },
                    { new Guid("ed215ba3-7f23-1f57-1438-0ae32ce91c57"), 2, new Guid("24c835e2-de12-eac4-6b25-d692546b46c1"), 210L, 185L },
                    { new Guid("ed6d22a0-ed42-0514-6750-5131a628ff66"), 2, new Guid("c233339a-ab6a-ac2a-a854-2dcaf17b8307"), 320L, 295L },
                    { new Guid("ef4aa946-3380-6b86-a1ed-38123f0dbabb"), 1, new Guid("c80ccf8c-82e4-95dc-a4ee-586bd11e06c9"), 1540L, 1540L },
                    { new Guid("f20dd591-6d76-2346-e8a5-7703a20d58c1"), 1, new Guid("aee54e20-f5b0-1657-8b93-b72c02d9c8e3"), 260L, 260L },
                    { new Guid("f23ccb2f-a5c8-fdf0-8503-9246f4981b65"), 1, new Guid("2db7f625-bf32-57ee-1bca-fa0d9f5ff4d9"), 510L, 510L },
                    { new Guid("f354ae80-de58-07bf-558f-38fd03e0f204"), 1, new Guid("502e7ac3-6b3e-9663-b3c4-3d5b0d935ed1"), 1130L, 1130L },
                    { new Guid("f43fea2a-f284-649f-7670-937662168bc1"), 1, new Guid("f3cafa40-5ac7-12ee-8840-19d94d4dd63a"), 360L, 360L },
                    { new Guid("f7114738-4123-4131-8e01-c4290fa11fe3"), 1, new Guid("8d0d96c6-31e0-7cf6-2072-191e0d6b5cf1"), 1120L, 1120L },
                    { new Guid("f80e3d13-b84c-deef-6e02-23fd52536fd7"), 2, new Guid("c355826f-8291-bf60-1b35-ba7323f13226"), 500L, 475L },
                    { new Guid("f84f9545-58b0-b2ea-d54f-73eb4f2053ff"), 2, new Guid("cc51157a-1595-4c33-afd0-7397bd34f462"), 1930L, 1905L },
                    { new Guid("f8654280-377d-3288-3f17-94aa64b20dc1"), 2, new Guid("0f3fb9be-1be2-721b-fdd6-b1dbc6a90957"), 130L, 105L },
                    { new Guid("f8d1d437-1706-d2d4-f941-56da94e8c763"), 1, new Guid("f670d4ae-7755-984e-3a49-f0896bd50790"), 550L, 550L },
                    { new Guid("fa6d4679-f45b-650a-517b-76cbd67740be"), 1, new Guid("8fd37a2c-8d02-3a82-1a42-5d023be1fb3f"), 1640L, 1640L },
                    { new Guid("faad0af1-4324-ae53-556c-771d3b148a7a"), 1, new Guid("c4d944fa-17c6-838e-285e-386144f3e635"), 1600L, 1600L },
                    { new Guid("fac8eb1f-6cc4-b3d2-fa49-801cf12c8ca8"), 1, new Guid("ca1ce149-019b-84e9-aa11-f720ccf3b895"), 1900L, 1900L },
                    { new Guid("fad0905a-2d3e-fb5d-5a91-f3bf32d20188"), 2, new Guid("fa9a2762-38ea-4934-91ea-8d78b47bb49d"), 1330L, 1305L },
                    { new Guid("fc1f063b-6511-ba3e-abc7-8cbdd9ae8d1f"), 1, new Guid("87784a5e-29cc-738b-13f3-2aa791e09779"), 1820L, 1820L },
                    { new Guid("fc2bb6e2-bf40-fe99-0574-24f6ad46160c"), 1, new Guid("3f105459-7ce8-9c0b-3968-571476428150"), 370L, 370L },
                    { new Guid("fc3579a4-a541-d7c5-81ec-ca4818980296"), 1, new Guid("5cf87699-cf68-636c-08ae-42806dfe7292"), 880L, 880L },
                    { new Guid("fcbbaa92-4e39-d7d2-c72d-977d36ec08ea"), 1, new Guid("29ee8664-1a25-e8d9-6275-69db69c05782"), 320L, 320L },
                    { new Guid("fed5a472-d195-c3e9-c383-80cd830426f1"), 2, new Guid("15151b02-a2a7-09af-b508-6ed76e1df2e8"), 550L, 525L },
                    { new Guid("ff86f550-a39e-9434-4766-373f94dc940c"), 2, new Guid("2a012a34-d935-a6d0-f06c-1d19399a143a"), 1710L, 1685L },
                    { new Guid("ffd31d60-bbb8-0287-dc00-4a5c5b325d5c"), 1, new Guid("c27aacc8-acaf-d342-4221-86776775b563"), 50L, 50L },
                    { new Guid("ffdf3f41-56dc-bbc9-af90-fc9522a0934b"), 2, new Guid("87784a5e-29cc-738b-13f3-2aa791e09779"), 1870L, 1845L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("00335a38-1f5f-a097-2292-eb99d7c7d2db"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0044632a-831b-a99d-2ac1-c586c7a6411e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("005d60a4-051a-608c-311e-eba7943cd493"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("00b538ed-1121-1b39-3327-bdf9ff7858ee"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("02aa0108-98c4-e4bd-8873-f326fd6af42b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("036f9fe7-a87a-d6f7-b952-cb161064a263"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("03a26c61-1a50-597a-c361-8137c05d7ff9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("055515f0-c977-a89c-fcf0-f31b16032b54"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("05589b07-4cbf-0786-2751-2a0260aa177f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("06ac826b-57de-5baa-64bc-2cfbd341c852"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("072c8a3a-9d8f-7e27-79e4-1b36b56ac3a0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0794ec39-6354-3e27-23a5-4df2e0afea3d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("07beb60f-a93c-ab8a-64f9-dfc9bedd82b7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("082c6606-c726-f8e7-7d6e-7fc7c6e1c8b5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0834c095-405b-9117-a4cd-e6a0c92f7521"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("08592f62-13d8-502f-71d9-42e2900f2e69"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0911fa8a-5940-268b-0923-4bc372c4f006"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("096e5289-c19b-6137-35da-881fccd5339b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("09c7d026-d3f6-bf20-4bcc-64b64df3558e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0ac6959b-17da-35fc-aedc-6bb450eaa696"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0b158981-9df7-9055-ec26-e9a0dad0a2ce"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0beeb48d-62c4-6069-50f5-a98595f3fecd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0d305d61-4f3b-aa14-9de8-2c589f43e5ba"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0e589f48-5526-1e9c-b2dc-8cab21ae9cab"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0f30ed65-e718-e348-3f43-598a27921acf"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0f9257c0-5283-b1b0-26e2-5cd64cf0fb64"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("0fbc2856-acb4-4df3-01da-9be9f63b1565"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("107f18dd-6f7e-80b0-df56-57b20e2dd558"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1106285e-cbb5-dd69-d916-30c78e807e92"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("129b85ba-36ed-f4bb-01c6-d8820e05759f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("134fb2e5-c641-62e5-0044-e8183027ed15"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("139bea29-1230-7cdb-9273-05cdf5e6c917"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("13c3b123-cfb9-993c-22a4-d75e07b01fd5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("14190072-b337-a01a-ac93-323da0a6ad44"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1441fdef-f8c9-2d60-e9ca-1d5742409761"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("14d75d10-a36c-f3dd-9da5-8be54cde2506"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("15b863a5-3315-f8fc-9bd6-e65c7216d33d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("15fbcb1f-084b-adb8-2f4c-371ac2ce4754"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("161c664c-c3e2-fdac-7830-afc166ad6465"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1679a348-9d6d-0704-f0d4-8f3238e30fa0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("16d9fa62-49de-5e3e-5ed1-85cd29b4d728"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("16ed1707-5c9a-e14e-ee9a-0f06942e92d7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("17043325-15e1-c707-86b7-4d55bee75597"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("17620c6c-ffb9-e58e-edd5-05b64d3ad337"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("19c257d7-4836-a560-79ae-329c6ddcb25d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1a806b0d-4ed9-8d0b-2076-96cec17854be"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1bfc2d16-e002-9537-5fe5-ddc279136ad3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1c7242f6-e2c7-779c-99a9-cee492f43cdf"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1dbfbb56-65eb-179c-b17c-2f8c4827d31f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1e10cc09-c69d-4230-a913-365973223a80"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1e3dc39a-5af9-b420-5a19-1c54dfa31e6f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1e731e75-a3e2-e261-0063-a081b5c10eea"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("1ea1f31d-1aaf-3f02-f183-081d7285722c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("20070a9d-c6cb-534e-51e8-a31fde1a4ab5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2314cc3c-4c24-848b-d9c6-e5ac0728b8d4"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2394e5d0-05ca-68a4-c869-29294d2cee78"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("25e11225-26ad-a484-e915-08ebde68c855"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2776cd59-9cd4-43af-92df-8bc4992c9552"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("279575e9-9dc9-027d-3708-e70cf278f10a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("27eb9b1d-4310-ba76-71fd-2130e916611b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("288769ac-a79f-9967-cb07-c2be1732870f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2a78bbce-12de-8a25-e898-fa988867c9f9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2a8e290d-a56b-ee90-4a53-52a026e562a3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2b16f159-2f5b-b858-0073-f2f4a4757cd8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2b29ac9c-7d74-c452-9c71-3178783799b8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2c8634ad-cb2d-ba7b-e3e2-6fc288e1f156"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2cfc564b-9070-84bd-82c3-18d173c2aa8a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2d9e4fb2-bd69-3665-274c-9d4f9bcf6d0c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2de65905-c09f-0df5-670c-dea0c7a04461"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2e24164d-ac60-a332-8f0d-46486f46108b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("2e70b533-148a-5aae-2695-17a74121097b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("30301d16-6824-eb5f-4d4d-2736fedda3ac"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3060bfdb-1027-8667-137b-f80a97818d40"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("30a30bdf-5a26-81a9-30ca-284719353ea5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("310e3d6c-5c68-29e4-cc1e-e761f26c5a7e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("312fb42f-d0ca-bd80-4e0d-914266893e36"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("33141f07-a4fa-c42c-14fe-41680b4a22d5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("335d82fd-744c-8282-83eb-8f5ac1a6d6ef"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("33e3b07b-339b-f431-e4d1-a510fd609ac9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("33fbc99e-f3a1-ef8d-2a2f-4722ad66a64b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("341e499c-45a1-72b2-0c4a-ca5048ec736d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("349e0e23-5a22-45b0-2c61-3b524abf1417"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3532271a-b5ab-f67f-78e4-066142e56f45"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("355ca7a8-b823-4a28-4982-f709800a9638"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("35c3edaa-ba66-b593-d0c1-2a21657c9512"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("362e024c-b1d5-0013-a643-149e566a74c7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("36fc422f-ba2e-f1cd-1179-af6761ec01eb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3710b129-b6ea-c1a9-81e4-685a19de8032"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("37793a02-4bdd-bf68-3d22-cb2798977f27"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("37ee0ea7-384d-fa46-0c5a-8005baaa46d1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("386abeea-7094-db23-5ac0-553fd1ff50eb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("39761630-fe46-1590-d4c0-67950d83088b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("39d2ccd1-da2e-75a4-7e7d-b501f0e6d92b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3a35ba9c-e9c8-4800-763d-e6d35c0a38e6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3a3cc48c-bb6f-258c-8efa-bec232c43537"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3aeacb07-fd38-c136-de7a-898204513cf5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3af956cf-2e03-3936-2cac-80cfe8b72456"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3bd7e1c0-025c-c9e2-c84f-d69a8125995c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3c108858-b385-623c-09df-414f70b37db9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3c2f5d70-553c-606f-b122-1ba00fe7ab33"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3cb736a6-d7e0-1ab6-c166-f34737cba13e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3cbd4bdf-ddf2-bff0-446f-ce4663c2e5ae"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3d688ebc-0091-39bd-db22-d4472c067918"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3e3baff4-7c06-c948-5df8-de1e84a167a7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3e436ccb-a4f5-0fd0-bde4-f4f76ce679cd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3f2c3857-6d32-ec27-07a2-1cff3f9fd073"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("3f7fc469-9405-0bad-153f-982e92ca7c31"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("414d7938-9290-7eb4-87e1-49e3f357607b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("41886368-03af-95f8-9aa6-b522ddde8a62"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4197bee5-2385-0d79-80e7-0c3281955ddf"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("41c7ab5e-fd9a-256e-8d9a-f8b8f5310ef7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("41f319da-2caf-a3ab-cd15-1634c66b548d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("421e5e35-25c0-98ab-8d9d-62927d112b11"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("428dc100-6d7a-d1f8-c67e-87ea6a72cc70"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("42f83dbe-415d-6adc-1e3f-8f6f2104486e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("433bde54-b1e4-e5ef-28af-ce5272963109"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("43618ca1-5eb4-0565-8915-b4f83454eee5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("43cf5bbe-5c53-0a3a-e98e-d5c9c86713cc"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("43d4373d-4f75-6da2-f48f-02fa2d5d1a3b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("474505a8-fa88-a60d-b177-989d6c554039"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("475e4a32-6ad2-19a3-c220-d392b223a624"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("48892550-6bad-e49d-1f8d-e67d4a05b0df"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("48ee7000-fefd-a6e6-3f31-0d265400b11a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("490dccd5-0d74-f308-2c4f-8e41ef60c184"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4a39b4e2-4cc5-6e1d-ff7c-ff1c820c4f1c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4ae1d143-0d27-e5e3-5b24-9ca0367167b1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4b5ae723-1600-06c2-4b8f-8f231c72139d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4be7eb23-4b62-9823-d972-dcc0d5397ec1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4c49768a-21f8-76ce-ffa7-ba41044d28eb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4c9a83b0-d2ef-1b15-6fed-e6ca44e68425"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4ca2f75d-3f1b-1a3b-a8c8-cec01bc79ced"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4cec23b8-57e5-18a6-c455-6338ec6217c2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4d5deaff-5bc2-a8af-d62d-f740705ffb64"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4dd5c1b1-73ed-9983-842a-c572327b955a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4edaea78-b646-4a49-58d4-f20e946f9ddb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4f251f90-2375-6f67-64f7-55f573246af5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4f7adacd-cb9f-c83e-517d-2993b0d56c4b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("4fddc3b0-8fbe-76a8-de59-4c56a2e75e92"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("500e3aa1-e634-0164-f051-743ce3927119"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("504c623a-ad0f-f22d-be60-4d211852f77a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("505aa05b-c0eb-0ef1-a305-6c653b73adf6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("51281b8d-19ac-8997-55c5-14cec9d50f73"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("518d14b0-18cc-5d54-4f00-23c56ebea4e7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("51ae08db-c5d0-0af5-a900-2699f92a219e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("52e3dac1-1c94-665a-c476-fc49dc160421"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("52f8cd6c-a055-3218-9f54-5e9467165ed8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("542fe386-122e-dae7-0d63-33dde88f9dd5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("54f0c2f5-2b65-d5af-886f-4576b2be7222"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("550c3854-3df9-a431-c183-df07ca3cd7ba"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("551336a8-915b-667e-5c34-446ef139bd42"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("552b9979-8a88-f3d3-d266-e0fae327907b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5580d9f3-75bf-883e-d7da-eeb825e82a18"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("55bb493d-87ac-7080-8005-61f54289f31f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("56aa8c58-decc-bfc8-c53a-db0b84df51c7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("57027cf4-ede1-e1ee-9b4b-4b3009acf26b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("573fc7d1-82c3-bd46-66d5-542ee516b9f6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("577a2555-fa4e-d1b6-c601-4de2ddaba7b8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5a2b3a70-b260-00cd-6caa-9b4c33893a87"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5b7671ae-d69c-2912-1fb0-d28fe6eebb36"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5d87b020-e6e7-746e-1778-58a3f6acc1a9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5d8d9f20-08ff-e5c0-8305-9b08a649d62b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5dfcdfcb-4c97-d82b-630a-9b1de51eda24"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5e39caf3-53ca-074c-0610-45542523aec6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5e9a5c1b-c10d-6545-2c05-a8b10ec703e5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("5f3fe616-d96f-a1c7-b03e-8dd0a5502551"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("61123c7a-672f-0b35-b827-76a05e1c943d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("61d4f4f5-c210-f071-81c5-eee76c9b7d5b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("63548019-475c-10cb-9004-4b2e1d9c10dd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("64c3ec5a-603a-7b51-7b74-2572f62cbb82"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("655e2124-a71d-c784-5c28-ae8095dd3e87"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("65983f5a-af88-a8a0-9bb8-d99a630a7cdf"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("670d533b-07e1-517e-a641-ac6977ac8bc2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6721c580-2368-496e-7ee8-9f57d3afc1f5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("68673161-e83c-47ef-78a8-a37715b068eb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6a839629-4b63-739a-c8f6-6117a386a26c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6b0a0519-1fa8-2ece-bfb8-718197cf9309"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6b7fccf9-29e0-c8cc-bdf8-66b965625238"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6ea487ca-d290-be53-2cbe-d6591981ed2f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6eb4505f-9e80-9f57-e9c7-119d1975ac63"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("6ee0aa12-4dd8-8b81-3182-ece7bc94e603"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("717a8adf-5ff9-bf2a-cd6d-d44e05e49264"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7268854c-dc60-de2a-3966-10735241388d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("728d4bcf-ba1f-448c-7d81-d8e0caaef414"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7468f171-8337-1fe2-955a-93817a0f00e3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("74bf04f6-5c2c-ab6e-dd8a-a991c16cfdef"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7553067f-d428-1968-c118-f07c5fee4a64"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("75b82bda-f1cc-dd8c-a581-734a4a6a5906"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("769aeb05-87a6-b885-b0ee-f2efff41852e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("77038801-ffac-9a3d-2f44-295f08a35bbf"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("77466724-c409-8f05-46a7-08c6cd8c455d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("778130e4-5ef1-55e3-6b8e-deb7f9910823"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("78ff9676-327a-eaef-997f-a7bc45f28c8e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("790ff1fb-40e5-5ebf-1e0f-9f574acd1255"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("795dc322-dc43-2f99-b419-5ceb14b35bf2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("79e9c451-f65a-7682-1d59-ad94582647a1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7a6c56f6-007b-1007-17bc-4cc266d03384"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7b38e775-6c72-6969-653a-0d7b276501a0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7baae726-cb74-e848-6c34-e68696cd1637"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7d5a2220-9e43-0a7c-fb33-31935afbc27c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7d8f9466-21e5-cdf3-770a-b09e24533dd8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7db94883-f9ba-16a8-0c0d-cc32b16f9f7c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7dcf2cef-8a53-8c46-1e19-b9a607a53c28"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7e88a6c7-b353-5fa7-5705-ee5e5b6a4bff"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7e8f32ff-ad95-c6a5-b1ad-2d2e317cf27b"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7eb9696a-294c-1965-f10d-71a284e6acc0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("7ee41d79-0594-634f-db8b-6d282c831e4a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("80114c8c-6dc5-c860-bc32-0d96976047a8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("82806811-ec03-dfbe-a029-f56a0f980c1c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("83e14578-6d36-635e-093a-9abd25ca97e6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("848b86ef-dc3d-40b6-57c6-37a3d579f5c0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("85109495-f35a-82d2-7519-fc0a2314f131"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("85599cf1-6ed5-5003-5c99-9f1661f548ca"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("85ebd5d9-e73f-adaa-c2d8-b3c7befc58b7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8731875b-41a0-dfac-ebcd-5deaf7048f3f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8876c90f-853c-13a7-4232-a31be550913a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("88a1b846-d721-490c-b683-f47ef91f4d63"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("88b161e4-3f34-fd29-1002-e01ce8a70c42"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("88e45c03-3408-3270-78bf-e4a367470b09"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("88fc25f5-104b-f4d2-c4fc-085fcb7caecb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8955bbf6-8eeb-a3cd-f072-029b88b62d04"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8a0f5991-a3a1-ac77-3885-a976e510a1f0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8a12afab-3914-4a65-6f03-61d65c7fa21e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8c189099-b9c5-031a-2885-429612e6cd85"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8c333547-2394-e329-e26e-fca79d19e712"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8ce9e348-6df5-f2d2-72cc-5623fac3b970"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8d1456b7-7052-ce83-577d-f3c8d5324262"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8d908e4d-90f7-2bf7-8a6e-adc7830d8cc7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8dc0805d-a1de-c0a2-203f-80b3dc146fe2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8ddebd05-d403-3b8e-5227-ae6239b9fdb5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8ed4c20d-6dc4-3709-8096-4e6b4adb0993"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8ee51adc-5e28-2eef-30c9-8d0fbfac7505"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8f9935c1-45c5-9991-0238-03181038aba2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("8fd54135-de30-aa06-de45-1ed5d795ce67"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("902b3626-c72c-b4e3-7807-0da50cdbd0c5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("903811f4-930c-808a-851e-c79be9c52455"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("90e16014-6448-8816-a0e7-923ff5bacc47"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("90f8e6f7-4e34-c3af-981f-ac578d341f9e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("912bc3b6-4bb8-5284-c889-163fae7d21b1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("912ceb8c-d7a6-7a25-4437-a57a306e5721"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("91ed21aa-db53-8e0b-4d5d-1e4698437b9a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("926f4f28-d01e-7141-6507-6d433c485194"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("927eb942-0b5b-2e7b-c8fe-a37e12a865a8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9386d52a-043f-b300-e992-f23e33d1ba96"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("93e0f596-9955-74ce-2443-05576d3c29f6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("94e04178-3409-c9a1-0cfa-e0dad3230023"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9553638c-17d4-3e57-76b0-c99f44317900"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("95df1dcb-1e19-8b65-d152-c1fe3afc5ef7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("96232c67-3879-4731-9cf0-0cc84cb369bd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("963e618b-3022-72b4-819f-dd9180f11b1a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("97b6751e-cdf3-a0ac-5b3b-bf43b2c8b982"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("98874e4b-928b-6964-a89b-6697cd8e39a6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("993485e0-411a-202e-8602-6f472d1bdbc9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("99c677f5-ceb1-cf2d-3a21-b39fe603eaf7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9a54093c-0e8e-c46e-66b2-525b611d7e24"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9a61b6d6-bb4b-293d-8b44-4f1d0ec2a57c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9a8f2442-87bc-e654-4047-336d699e8754"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9ad88df6-5bb4-8cfe-da2a-8dbff9b54c52"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9ade08e2-30b7-a16b-52db-5b33bdf09c08"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9b2cf3fc-f03f-3892-8056-bf8871820cbe"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9b72b6ef-51eb-9bab-de5e-9566050927ab"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9df88b8d-9531-0567-6f6e-6786458bb6b0"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9e4fc22b-8fef-2017-ad7c-677a08cfe10a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9e5187a8-a249-283f-842f-ace382f6b387"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("9efead15-44db-155c-33a1-fd83412ab3ca"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a029014f-2be7-a6e4-7ebd-f968e5bc527c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a02960b9-ad8b-b06c-aea5-dc0480510c37"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a05551c1-48b1-15b0-e8f6-c2994e5ca3d8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a0c832a7-7d0e-ffd7-9d67-0c330485fb5c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a0edb419-56de-4e51-f3fc-8bf81897c826"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a13689c6-3a25-6031-b9ff-34edff71fa05"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a23a9ed4-612a-3692-52f6-611d7c409526"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a4a34be5-6ed9-bb78-fd34-76bdc008d710"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a4e8a0b8-c2fb-75bd-f65b-0e713663d3f3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a545a355-d638-bcaf-70d7-fc69be5ef39c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a68dad80-0f80-da2d-b929-e1b2676f4ae6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a6a91b4b-4264-21d0-15e9-cb47ec3c8e86"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a89d299b-1beb-4523-0ba8-8042e9fdedfb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("a98827b8-5eb4-5f68-9237-6083fd6cbc3a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("aa575d69-0cc7-4955-6deb-08d102590044"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ab9e0be4-6d37-4951-a5cb-208305e0dd00"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ab9e57ef-6080-9376-541d-104098354a87"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("abf20486-17c6-e186-1248-f26c81758061"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ac1db940-634c-6a11-6d59-e95f9f79fe49"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("acd3d35a-8f68-b4c0-d85c-54b997994e34"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("acdfd5cb-e22c-88d5-86bf-6550b6d1a8e1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ad4be044-2796-4174-fde8-bd8144752834"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ae7288f2-bdba-c49a-bd7a-abe65701a1dc"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("af4e32ef-efdc-1c0f-2888-67d24e894980"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b17dba13-e9b8-cb27-5e3d-f5b3d19c2fe5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b3bb70a1-0251-22ef-7724-2f8c080921f8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b3ef519f-4643-771c-b791-bcdff75fc7a5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b4a71e91-a5bf-b509-8b06-fcd98f9ebbc3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b5554aa4-b648-b588-569c-3d7b00087088"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b5b8a821-b9c8-08f8-c70c-7a88a1b1296d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b5ed09dc-6583-65b5-0943-7d86331b1879"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b68717a2-df1d-50df-9b6a-475dfcbcf130"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b6d2504b-3df7-8804-cc01-3f3936ca8318"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b6ea6230-2352-3938-2634-704435b9daae"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b953f7e0-5fa6-b286-2fa7-9f0e0a346f3c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b95d5317-7d16-a7e2-0cab-3894be534802"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("b9ddac31-5c73-1c8c-4378-2f9e83f174a4"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ba21ac80-72a6-d6d7-66ad-ecf6f690e363"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bb0706b9-6bab-2e05-7f51-04779969b931"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bb238bc5-1580-980f-1e02-c933390b27ee"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bb52f140-dc6f-cc28-645a-3bf5b2d8638f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bbc44fdd-99f7-a808-368e-8c9321b523ca"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bbd920b1-7a6e-d89a-265f-dd702fe947fd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bc84d7b2-4abb-751c-6fb6-4f525acd82ab"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bf1cd5ac-a407-0302-5d52-a0da74061124"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("bfa37299-0893-bd82-f5c4-811f35f15789"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c025ca2d-7551-dbda-89c3-8ee05ebf5747"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c0b91164-cd21-530b-2c7f-6b04d397795d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c0d2d3af-2275-d5f8-666b-2ebe329bb49e"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c17a11df-6b4e-9955-fce8-2361035f0a5f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c1bd22fa-49b4-5ca8-91fc-6ea90ca4231c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c3934e84-87d5-7dd3-fd62-bea5e97df5a3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c3957dd0-5844-a926-5720-d05cce47da13"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c3d621d8-64c3-6d1b-7244-7b27d13214a6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c40b7a24-be54-13fc-3a8c-6f4fb019041a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c4b71877-3268-180d-9170-81401c8b7a2f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c4dd8023-856b-0ce4-ed63-5761b5d884d2"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c5843886-55d1-2415-41bb-0ae069048e30"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c62b7dea-7927-344a-ed75-5e74a8f2625a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c6872089-cbd8-6f43-5b0d-026c9590d825"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c6d9f890-f62d-a917-285b-f6f91da60428"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c720d6db-1495-e1db-f5a3-f2a9e8bfbd1d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c7ab91d5-31e0-bbc6-8e18-0835925288aa"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c9134035-900a-cd57-d1d0-33ba529bd2e1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c9c0f78e-2c3e-8a8d-de6d-27e63d44be76"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c9e575b3-1455-078b-c2ce-70e6b565acd6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("c9f2a040-fbb8-a125-84d7-5ed1c4af7be5"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ca19f1bd-07a7-8e1b-c9fe-a68b771c57eb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ca97897f-a42b-b149-b4ae-3d9f4a21c6cb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("cad42b03-a2b8-1c79-6476-8de6677bf47d"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("cb86052b-56d6-3033-5d13-8dbfaf33e0bb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ccb9dfb5-435c-4b2f-42d6-fd3a8d625591"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ce1276a8-aa6c-abf0-a678-8bad12d3c2c6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("cef99144-f1c7-7df0-7478-5cffbf9a52c1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("cfc163d9-3701-b26c-c50a-254d870f147c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d1a8bc5c-8240-c493-d328-eb49e416720c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d26c59f8-4fa2-8c6e-e925-d63268c1f534"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d2974373-060d-cfed-9518-024e2f6c91e7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d2cb5bb6-4906-a252-7e27-47cdee442843"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d2d4a3a3-d729-efc0-b776-8f5dd2f59ae8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d2f6d284-8e95-96b8-d3a6-714f52b114ec"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d440d969-7076-e4b1-2478-40ca7ca4b3d4"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d5333915-c60f-fc87-4009-220bcb26e532"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d554cdc4-d384-5355-6a14-267d6458b2c9"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d5f45410-74ef-9356-9281-0c5ad9f5033f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d693a00a-5b73-754a-dbb7-c6634518c042"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d7473352-63e5-ed74-28c7-10b30c8a4852"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d74be5fa-5ace-cced-0413-c6c1472b44fd"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d854b8e4-156b-9ea1-b1eb-93cfb64705b4"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("d85e7f13-2cec-ff65-1148-962702e594bb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("dc0885f9-6d4b-a9f8-3302-a39f5b042933"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("dd15499f-6ab6-d856-1844-25f37c6be80c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ddb5c26b-bb0c-025a-4381-056dda259b44"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("dea79594-db74-4f5a-9ec6-d7d64cd253dc"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("df97bd76-140c-e11e-13af-ea4d31465866"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e01d163e-a94c-15f7-ecd8-9b590991dc4a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e042ecb0-13c3-76ea-3367-6c8822f1dd81"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e09e3a71-60f8-b9e7-8fa8-b8a695c66fce"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e2abe0b4-83f2-29b9-37fd-31fc7ed42234"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e3c531c8-7fc4-f39d-3800-c41fcfcff461"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e3f23dcf-6187-1c93-47b9-cdf8da46a624"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e52e4949-ec58-b9ba-ce10-76c6a18159b7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e53d8b5e-97db-2547-6f08-5e58dc0eddd7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e5563972-54d3-9501-8d83-89b92d0181f6"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e572a812-d1a6-db37-cb43-b8d5ea12c6a8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e5a466db-041a-423a-176a-f8ae55e04281"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e657bc34-665e-e4fa-4416-b119a2bafe65"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e6ca9940-e233-aef9-ac71-63cc143862ec"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e7508501-f96c-2732-1b8b-a04fdc0fa5b4"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("e9f5d24a-8cc6-41cd-f82c-4bca6d82c6e7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("eb0e562c-703b-758f-a578-eb35e36dc536"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ec08d5b3-5449-5e39-2e3e-8a3726f36212"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ed215ba3-7f23-1f57-1438-0ae32ce91c57"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ed6d22a0-ed42-0514-6750-5131a628ff66"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ef4aa946-3380-6b86-a1ed-38123f0dbabb"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f20dd591-6d76-2346-e8a5-7703a20d58c1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f23ccb2f-a5c8-fdf0-8503-9246f4981b65"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f354ae80-de58-07bf-558f-38fd03e0f204"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f43fea2a-f284-649f-7670-937662168bc1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f7114738-4123-4131-8e01-c4290fa11fe3"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f80e3d13-b84c-deef-6e02-23fd52536fd7"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f84f9545-58b0-b2ea-d54f-73eb4f2053ff"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f8654280-377d-3288-3f17-94aa64b20dc1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("f8d1d437-1706-d2d4-f941-56da94e8c763"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fa6d4679-f45b-650a-517b-76cbd67740be"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("faad0af1-4324-ae53-556c-771d3b148a7a"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fac8eb1f-6cc4-b3d2-fa49-801cf12c8ca8"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fad0905a-2d3e-fb5d-5a91-f3bf32d20188"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fc1f063b-6511-ba3e-abc7-8cbdd9ae8d1f"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fc2bb6e2-bf40-fe99-0574-24f6ad46160c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fc3579a4-a541-d7c5-81ec-ca4818980296"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fcbbaa92-4e39-d7d2-c72d-977d36ec08ea"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("fed5a472-d195-c3e9-c383-80cd830426f1"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ff86f550-a39e-9434-4766-373f94dc940c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ffd31d60-bbb8-0287-dc00-4a5c5b325d5c"));

            migrationBuilder.DeleteData(
                table: "Points",
                keyColumn: "Id",
                keyValue: new Guid("ffdf3f41-56dc-bbc9-af90-fc9522a0934b"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("00c2cb5a-2469-1b5a-1c9c-5dec45703795"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("022dea00-f565-b9ff-265b-7a5dc2bbcfb5"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0470a4de-e475-cc94-b72d-17da8f14672d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("09a9b5ec-4ff1-4557-2900-cf30cb05e9ff"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0b19c87f-a9ac-1a6a-b60f-81fbeb4f3d16"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0dfa902a-c2a8-8f93-c30e-ed531be36158"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0e5618f9-a4ce-9337-9179-a58be10c7e96"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0f3fb9be-1be2-721b-fdd6-b1dbc6a90957"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("0fb3e3e5-97ca-9ab9-b369-64df63169ddd"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("107faa47-862d-1686-64ec-36bcd8eaa706"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("129ec3fd-827e-c5f7-a954-b0484f45ba38"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("13dfca12-6a42-0cef-59d8-507164cce32f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("14b38d22-8237-bfb5-de0c-7c2d95f9b2b9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("15151b02-a2a7-09af-b508-6ed76e1df2e8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("16238310-1257-db51-e212-02975fca2cc2"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("170f2038-72a4-761b-a5d5-1ac10959d5ca"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("17f499fb-93b1-ac0d-d49e-1b16f66c2084"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1837fb87-8c80-2fe2-3de5-851b7b1c29fb"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("19028085-2b9d-8cec-a2be-3d1b74116716"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1a2a48b9-41df-1b22-6ccd-aea89127d4c8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1c036160-5157-a994-ef07-c4b88323bce2"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1d8f562e-029b-d558-72f8-2264d5a86178"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1f868a0c-6ee9-47ab-3372-b3ac9dc69c3d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("1fdb01a1-1ae7-d326-7621-e779c5983b76"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("21a97a27-a9e9-7cfa-1950-beb9a1d11212"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("231ae598-8f0c-387a-6ff7-6981c0859dc6"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("24c835e2-de12-eac4-6b25-d692546b46c1"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2555c940-3884-f262-627e-7fbcb3009c88"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("27688d61-3018-c7a3-48fc-80903c3bf678"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("28058790-f46a-ec31-086b-d564b402596e"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("28fd3600-8963-7f02-6eae-68f89d0f4cb7"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("29ee8664-1a25-e8d9-6275-69db69c05782"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2a012a34-d935-a6d0-f06c-1d19399a143a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2c50b4c2-a5d8-b806-68df-532fa7c6ec98"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2d6edfdf-09e6-aa11-6830-18fc36b9d43c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2db7f625-bf32-57ee-1bca-fa0d9f5ff4d9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("2e3e4f1c-cf61-378d-4632-991820965c3a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3035d2fc-b171-a5e0-c842-fb7c36f237f9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("303d389d-2832-a934-3cf2-93f29f9dd2b2"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("336758e1-90b7-bd47-6367-aee7b368cc06"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("34894fa5-c10b-d8f7-b01d-f6c224fde3c3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("34cf2c3b-e6a2-816d-2e44-ccbecfd0be17"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("38dfac91-2f97-00c2-6b00-3dab16e71f67"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3a5908c6-a9a1-6fe5-14bd-3e24be71e64c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3a7eb1c5-294d-35b5-9430-22fea88a0e26"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3ce03eb3-0f9e-a093-f328-a5fa7b763833"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3d24d818-ca52-ff8f-8929-3ae4e072f6ca"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3dfc83e4-ef66-2e4a-d492-634707a5f323"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3ea37e30-a85c-e1e6-48ff-d8dca022714d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("3f105459-7ce8-9c0b-3968-571476428150"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("40cb5017-ce99-922d-f32f-34f3a50f86c9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("413faafd-7393-c8ba-6702-41f07e80acd7"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("41c4b5aa-6dea-c363-4d42-5659947a3cb2"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("42a48900-b3f5-4490-7746-99a042f69d04"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("434f78d6-4b00-059d-562e-7f1200fce396"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("43973915-90be-5c06-56dd-9485c346c629"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("443541d4-e78c-e425-b6df-07be9b0be719"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4481b838-e954-dd1e-9fa6-3b0690f98c5d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("44e9379e-1450-e3c1-e9b9-64423b924d07"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("44f8cf75-c6c4-84c0-8fff-70f3e8fa344f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4a86e21d-0989-48fc-1581-554b77eadbee"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4c28273b-1c68-47f9-e951-4b25af60b994"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4cca7a30-69a1-a3ae-8b72-23f3e93db1a7"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4d2d36c5-a588-e435-6804-56f474a790be"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4d4d57f8-4a7e-ce70-50e9-e442031a3f50"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("4e411548-2788-eea3-650a-5b76eb7063f7"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("502e7ac3-6b3e-9663-b3c4-3d5b0d935ed1"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("507689f8-271b-9360-38bc-88cc0794b001"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("5121ec2a-aa0e-861f-e169-52232ba0f413"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("53784a22-a8e6-8148-39c1-0a86fd447266"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("5616eb07-fad2-8657-20a8-a9566a310070"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("5acd19ca-2dc4-5198-de04-36d98767d991"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("5b9721b8-da76-9046-9773-149c207231f3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("5cf87699-cf68-636c-08ae-42806dfe7292"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("602604b0-f2b9-7927-d12a-b2e8746119f8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("60991c5b-63af-3754-df6f-b7869229070c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("61b6666e-deba-1f88-e6ea-3a0040e3063c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("64d28203-26be-91a8-21a4-d7258552e00a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("65afa446-279a-adff-2e86-ff1006f27c44"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("666cf265-4716-9899-9112-b85ba718d6e0"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("674a5b79-5846-9bb3-2143-320816452523"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("69c42663-340d-2452-e12b-8a711e1f712a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("6c93d106-2377-ac9f-0f63-cf46de241ecf"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("6d7e1561-5a42-3776-e44f-655790382842"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("70ba4948-9e0e-8593-2fb1-db0f40bd6714"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("710a05a6-9f00-3f6e-108c-2eb024aca859"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7115bae7-a9b2-b31b-8f98-f3d5b4f3c221"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("75b6efb1-f7fe-c88d-ce17-bd4f7b5fdffa"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7737b8b9-2996-bfdd-1727-4ac61d100a6a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7782cc16-346d-5ae4-27d6-927bdf9a57bf"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7786a0e3-c9f9-2958-ddea-1c95e9239e27"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7b37db38-4364-2701-1883-6d94623546ea"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7ce2d7bd-cd53-4988-1e9d-d23d6b325edd"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7da9f293-4b0a-b878-4ddc-e9f6a9d10940"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7dfef5b9-09c4-885e-1dac-3e8eed0e1571"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("7fb2938f-1e65-c1df-7efb-bd481ec0e4e6"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("84c7845f-8b20-14b2-918f-ab5731597412"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("85f73e5d-db6d-4568-0134-3b27a4062c34"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("863e291c-d1a1-a10c-42a9-4bfc5650861c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("87784a5e-29cc-738b-13f3-2aa791e09779"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8c489491-8577-99cd-92c3-24001e4ef359"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8d0d96c6-31e0-7cf6-2072-191e0d6b5cf1"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8d602441-288d-a27e-ce6a-c64495b24acb"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8e41fa3e-863f-e902-6907-7660401a7de6"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8f925157-7f45-11a5-d22d-75a235faa9bc"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("8fd37a2c-8d02-3a82-1a42-5d023be1fb3f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("91917c7b-b6d9-bbd0-2d18-57c0974af437"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("953284b8-b292-e221-6865-1f94aaae8b99"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("96973aa0-108e-ed71-7642-22d2c0cfa55d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("96eecc1f-f858-df1c-eee4-b54ede86489c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("988ea22f-2615-f10a-b166-e5e6ff93d773"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("99508c9a-4ef4-2e19-86aa-c72da0c95990"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("99cc83a5-fc59-58c5-4314-6010179e7a1d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9a86c369-6b0c-b985-fd4d-1e5d21e2a81e"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9aaa47bf-7cfc-b8b2-d24d-3dbb68360b01"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9abddb69-1fd7-1bf6-9028-22a9ed2d2f9d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9c036704-bf33-aeaa-3ac3-5d0561026a7f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9c6b938a-ae21-1704-6684-d9448e307263"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9d158a53-8136-3d3e-5bdf-06a23fc8f1e3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9d397c3b-242c-8187-5b4a-daaceca70df8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9e2a8fe7-5d1b-50e2-75bd-5ce2f06e6621"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("9e3990c7-7634-af3b-eef7-23a8117e4beb"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("a30664a7-6f7c-8e1d-27c3-fe869fac97c3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("a5e30094-19f9-fb32-d1e0-e3c239f79fcd"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("a63febd7-8649-e66f-40b3-12bffa111fb9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("a691bdb8-8249-f784-0afd-fbd3cc126162"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("a9f6a116-b1b0-9031-78c8-e20b4fcd62af"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("aee54e20-f5b0-1657-8b93-b72c02d9c8e3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("b307f16b-a703-0fca-36e3-9ed0637db79e"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("b58ddcde-644f-1c33-717b-6149c8da020a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("b7fced86-fec2-906c-d286-86124156f077"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("b92777ca-38f5-a1df-7e27-a0e117be2fcc"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("bea2ceec-11f1-521a-a0bd-7711598e3cba"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c233339a-ab6a-ac2a-a854-2dcaf17b8307"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c2559da7-256b-eeb7-9782-30075b0a95a5"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c2587625-f94d-2da2-75e1-ceda5559456c"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c27aacc8-acaf-d342-4221-86776775b563"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c30814d3-bb97-4a34-7b3e-d226223e1c65"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c355826f-8291-bf60-1b35-ba7323f13226"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c39f5a72-d208-ea5e-8c7d-602caa143cf9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c430c395-4493-6c05-b7b4-82e3a62e3d9f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c4d944fa-17c6-838e-285e-386144f3e635"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c4e3800c-2c1a-02e9-cf80-fd3116933c5f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c52e968e-9a52-c70d-7d2f-97f88c22bdbb"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c631668b-768f-2f5c-e193-5fe2c33c6714"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c6ec4a1a-8d23-c730-ffeb-25a9e655f2fe"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c80ccf8c-82e4-95dc-a4ee-586bd11e06c9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("c9829083-d68f-509d-7335-6f85e46046e0"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("ca1ce149-019b-84e9-aa11-f720ccf3b895"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("cb8e69e0-97cd-cb71-5993-26c1fb37f93b"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("cba75903-7e3e-cc4d-9e89-01ce3a4e8912"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("cc51157a-1595-4c33-afd0-7397bd34f462"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("cc75fc4e-b195-9dd0-a6c5-eea199d097e0"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("cf0323e5-496c-5eaa-1f70-16742ca7708e"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d25ae26b-9a99-2bf5-a0ec-c4abf10e8f36"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d2807232-4060-4a36-97ff-97d3602c14a7"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d2e0941d-13d7-3f43-3fff-5521187454b6"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d40fe671-4324-db55-3412-ff961b071778"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d4be6ec7-da93-6cb6-5d76-9cdbf0c4eb63"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d57f05d3-986a-8e34-fb0d-1e1cbd3067aa"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d66dd9fc-8734-870d-d07c-082b0103f016"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d6c20696-a5af-bd1f-a61c-f0f552fb8287"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d77151b7-2509-309a-5e9c-0a9edb34403d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d8edbb0f-5097-4474-d75c-427cf67531ab"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("d8f2c1b2-22ee-a4f5-96e4-f3ebaaec07f3"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("db9631f1-4e22-52c3-835b-9b614823f479"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("ddb9c3cc-b3fe-707f-f885-7f93bf37030d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("de1aabfc-b112-376e-1836-5a49d6eaa77a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("df949aa7-214c-c52f-e0cf-302c97c0ca75"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("dfdc9bd4-45d7-2a66-feb1-faa6989aaa88"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e1d888b2-b6cf-c80b-0fb2-75bc27bf2673"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e2456da0-f70a-95da-5295-09641e009768"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e39df5dd-e61e-c4f5-5f15-ed7c6f98c697"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e512b5f7-d2c7-7bbb-d976-9c228b83abe9"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e5e243df-c4b1-d035-d4da-bf71451be3c2"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e60739fc-9638-cd5b-aaba-4713f9c9bf13"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e696ad10-d5c2-0f9e-1631-682ef2de619a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e6dcb8dc-e53b-890c-7f2f-32e86a694aba"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e7589363-cbd4-89c8-5361-af71cce01a4b"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e78b6e73-65d7-14e5-2c17-8a01610eb906"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("e99f14f7-4e48-119e-536f-b488c18f3448"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("eb2e251b-8c1c-78d0-f7cb-002d49330f9a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("ee72f412-8473-7247-f7c1-c5c0285464e4"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("ef938078-0e91-ba82-1135-c26daadf1992"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f00194c0-bd1f-4eed-908d-86a69ab55815"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f11e4571-fa3f-c11d-437f-d81e07a8c0a6"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f13a1a86-937f-68e0-4060-52fd3715a9d8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f333db94-f998-8374-a125-af7d94171270"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f35389e3-d31e-3cb9-32e4-6df93cbe8a3f"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f3cafa40-5ac7-12ee-8840-19d94d4dd63a"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f4e0c2f2-b82d-855e-4d13-4020bec28906"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f604ec93-484b-46a1-a1a7-97223c2d8387"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("f670d4ae-7755-984e-3a49-f0896bd50790"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fa9a2762-38ea-4934-91ea-8d78b47bb49d"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("faaceb45-0c82-be16-365f-84e4baf31787"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fb8c525f-5b67-c464-5dc0-5178182ed972"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fbd3278e-fd98-690d-a67c-a88f575a80fe"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fbdcbd39-0e5f-f43e-23a2-e784db4a2778"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fc01d7b5-55c7-7a4e-3082-762ad9fae1c8"));

            migrationBuilder.DeleteData(
                table: "Shapes",
                keyColumn: "Id",
                keyValue: new Guid("fd7989db-e04e-eac9-5ee9-25a296c84d4b"));
        }
    }
}
