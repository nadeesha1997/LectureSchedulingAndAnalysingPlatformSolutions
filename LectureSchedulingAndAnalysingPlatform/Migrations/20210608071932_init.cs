using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElectricalMail = table.Column<string>(nullable: true),
                    CivilMail = table.Column<string>(nullable: true),
                    MechanicalMail = table.Column<string>(nullable: true),
                    ArMail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    HodId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Hods_HodId",
                        column: x => x.HodId,
                        principalTable: "Hods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    RegNo = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Semester = table.Column<int>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    ProfilePictureName = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PermissionType = table.Column<string>(nullable: true),
                    BuildingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Halls_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineSessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(nullable: true),
                    MeetingId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineSessions_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineSessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubjectUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    SubjectId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectUsers_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    Permitted = table.Column<bool>(nullable: false),
                    SubjectId = table.Column<int>(nullable: true),
                    HallId = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Halls_HallId",
                        column: x => x.HallId,
                        principalTable: "Halls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 4, null, "Administration Building" },
                    { 5, null, "Lecture Hall" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Code", "HodId", "Name" },
                values: new object[,]
                {
                    { 1, "EIE", null, "Electrical and Information Engineering" },
                    { 2, "CEE", null, "Civil and Environment Engineering" },
                    { 3, "MME", null, "Mechanical and Manufacturing Engineering" },
                    { 4, "IS", null, "Interdisciplinary Studies" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c5f5f2ea-2053-47fc-a52e-362644c88f8b", "b75e0ae5-9273-4dfe-9526-014be3a90b11", "Admin", "ADMIN" },
                    { "5d3c14b4-6315-4fa7-82f8-1500b647089c", "172dc9f2-683a-42bb-a869-8c0451f67149", "Student", "STUDENT" },
                    { "57ac6896-8ab8-45ee-9f1a-d1fa0e75e196", "1a6eedb2-7637-4538-b72a-767746322755", "Lecturer", "LECTURER" },
                    { "a6e8ad25-ef35-4ed6-a540-4f2a90fb3d6f", "2b575f42-7bc2-4843-9024-537fae3957be", "AR", "AR" },
                    { "e36982ba-90d8-43af-bb25-ef2bd938cdf8", "3287e2e6-9f4a-40c8-b7f8-3545b01cc3e8", "HOD", "HOD" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 6, "CE3203", "Engineering Surveying" },
                    { 117, "ME4311", "Analog and Digital Electronics (TE)" },
                    { 118, "ME4312", "Automobile Engineering (TE)" },
                    { 119, "ME5301", "Computer Aided Design" },
                    { 120, "ME5302", "Electrical Power and Machines" },
                    { 121, "ME5303", "Mechanical Engineering Design" },
                    { 122, "ME5304", "Refrigeration and Air Conditioning" },
                    { 123, "ME5311", "Mechatronics (TE)" },
                    { 124, "ME5312", "Marine Engineering Knowledge (TE)" },
                    { 116, "ME4304", "Mechanics of Machines" },
                    { 125, "ME5113", "Technical Report Writing (TE)" },
                    { 127, "ME6301", "Advanced Fluid Mechanics" },
                    { 128, "ME6302", "Automatic Control Engineering" },
                    { 129, "ME6303", "Computer Aided Manufacturing" },
                    { 130, "ME6304", "Production Planning and control" },
                    { 131, "ME6211", "Nanotechnology (TE)" },
                    { 132, "ME6312", "Robotics (TE)" },
                    { 133, "ME6213", "Research Methodology and Ethics (TE)" },
                    { 134, "ME6114", "Technical Presentation Skills (TE)" },
                    { 126, "ME5214", "Advanced Automobile Engineering (TE)" },
                    { 135, "ME7301", "Maintenance Management" },
                    { 115, "ME4303", "Manufacturing Engineering" },
                    { 113, "ME4301", "Applied Thermodynamics" },
                    { 95, "EE8205 ", "Software Architecture (TE)" },
                    { 96, "EE8206 ", "Computer Graphics (TE)" },
                    { 97, "EE8207 ", "Optimization Techniques for Engineers (TE)" },
                    { 98, "EE8208", "Intelligent Systems Design (TE)" },
                    { 99, "EE8209", "Microwave Communications (TE)" },
                    { 100, "EE8210", "Digital Communication (TE)" },
                    { 101, "EE8211", "Design and Management of Data Networks (TE)" },
                    { 102, "EE8212", "Biomedical Engineering (TE)" },
                    { 114, "ME4302", "Design of Machine Elements" },
                    { 103, "EE8213", "Photonic Devices (TE)" },
                    { 105, "EE8117", "Video Compression and Communication (TE)" },
                    { 106, "ME1202", "Fundamentals of Engineering Thermodynamics" },
                    { 107, "ME2302", "Introduction to Materials Science and Manufacturing Engineering" },
                    { 108, "ME3301", "Fluid Mechanics" },
                    { 109, "ME3302", "Metallurgy for Engineers" },
                    { 110, "ME3303", "Modelling of Dynamic Systems" },
                    { 111, "ME3304", "Strength of Materials" },
                    { 112, "ME3111", "Engineering Design Methodology (TE)" },
                    { 104, "EE8115", "Introduction to Hardware Description Languages (TE)" },
                    { 94, "EE8204", "Information Security (TE)" },
                    { 136, "ME7302", "Production and Operations Management" },
                    { 138, "ME7604", "Undergraduate Project" },
                    { 161, "IS4103", "Appreciation of Music (GE)" },
                    { 162, "IS4104", "Digital Modelling and Animation (GE)" },
                    { 163, "IS4205", "Aesthetics and Design (GE)" },
                    { 164, "IS4106", "Spiritual Development (GE)" },
                    { 165, "IS5301", "Numerical Methods" },
                    { 166, "IS5202", "Industrial Safety and Resource Management (GE)" },
                    { 167, "IS5303", "Financial Management (GE)" },
                    { 168, "IS5304", "Industrial Management (GE)" },
                    { 160, "IS4302", "Technology and Society (GE)" },
                    { 169, "IS5205", "Information Literacy and Scientific Communication Skills (GE)" },
                    { 171, "IS6202", "Introduction to Sociology (GE)" },
                    { 172, "IS6203", "Entrepreneurship and Project Management (GE)" },
                    { 173, "IS6304", "Management and Organizational Behavior (GE)" },
                    { 174, "IS7101", "Engineering Ethics (GE)" },
                    { 175, "IS8201", "English for the Professional World (GE)" },
                    { 3, "CE2201", "Fundamentals of Fluid Mechanics" },
                    { 2, "CE2302", "Mechanics of Materials" },
                    { 1, "CE1301", "Introduction to Civil Engineering" },
                    { 170, "IS6301", "Mathematical Modelling " },
                    { 137, "ME7303", "Solid Mechanics " },
                    { 159, "IS4301", "Probability and Statistics" },
                    { 157, "IS3206", "Physical Development and Health Management (GE)" },
                    { 139, "ME7311", "Advanced Marine Engineering (TE)" },
                    { 140, "ME7312", "Energy Technology (TE)" },
                    { 141, "ME7313", "Industrial Automation and Control (TE)" },
                    { 142, "ME7314", "Polymer Technology (TE)" },
                    { 143, "ME8301", "Heat Transfer" },
                    { 144, "ME8302", "Industrial Fluid Dynamics" },
                    { 145, "ME8311", "Aerospace Engineering (TE)" },
                    { 146, "ME8312", "Energy Management (TE)" },
                    { 158, "IS3207", "Introduction to Astronomy (GE)" },
                    { 147, "EE8212", "Biomedical Engineering (TE)" },
                    { 149, "IS1302", "Communication for Engineers" },
                    { 150, "IS1401", "Mathematical Fundamentals for Engineers" },
                    { 151, "IS2401", "Linear Algebra and Differential Equations" },
                    { 152, "IS3301", "Complex Analysis and Mathematical Transforms" },
                    { 153, "IS3302", "Society and the Engineer (GE)" },
                    { 154, "IS3303", "Basic Economics (GE)" },
                    { 155, "IS3104", "Graphic Design (GE)" },
                    { 156, "IS3105", "Creative Dance and Oriental Ballet (GE)" },
                    { 148, "ME8213", "Individual Research Project (TE)" },
                    { 5, "CE3202", "Concrete Technology" },
                    { 93, "EE8203", "High Performance Computing (TE)" },
                    { 91, "EE8301", "High Voltage Engineering (TE)" },
                    { 29, "CE6251", "Building Services Engineering (TE)" },
                    { 30, "CE6252", "Dynamic & Control of Structures (TE)" },
                    { 31, "CE6253", "Ecological Engineering (TE)" },
                    { 32, "CE6254", "Coastal Engineering (TE)" },
                    { 33, "CE7301", "Construction Management" },
                    { 34, "CE7402", "Comprehensive Design Project" },
                    { 35, "CE7203", "Computer Analysis of Structures" },
                    { 36, "CE7304", "Environmental Management" },
                    { 28, "CE6106", "Surveying Work Camp" },
                    { 37, "CE7305", "Geotechnical Engineering Design" },
                    { 39, "CE7607", "Undergraduate Research Project" },
                    { 40, "CE7251", "Coastal Engineering – Application and Management (TE)" },
                    { 41, "CE7252", "Ground Improvement Techniques (TE)" },
                    { 42, "CE7253", "Highway Maintenance and Management (TE)" },
                    { 43, "CE7254", "Water Reclamation and Reuse (TE)" },
                    { 44, "CE8252", "Irrigation and Watershed Management (TE)" },
                    { 45, "CE8253", "Water Resource Planning and Management (TE)" },
                    { 46, "CE8254", "Analysis and Design of Large Structures for Dynamic Loadings (TE)" },
                    { 38, "CE7206", "Introduction to Research Methodology" },
                    { 47, "EE1102", "Introduction to Programming" },
                    { 27, "CE6305", "Geotechnical Engineering" },
                    { 25, "CE6303", "Engineering Hydrology" },
                    { 7, "CE3304", "Fluid Mechanics" },
                    { 8, "CE3205", "Structural Analysis I" },
                    { 9, "CE4301", "Design of Concrete Structures I" },
                    { 10, "CE4302", "Engineering Geology and Soil Mechanics" },
                    { 11, "CE4203", "Structural Analysis II" },
                    { 12, "CE4304", "Transportation Engineering" },
                    { 13, "CE4305", "Water and Wastewater Engineering CE4305" },
                    { 14, "CE5201", "Design of Steel Structures" },
                    { 26, "CE6304", "Environmental Engineering Design" },
                    { 15, "CE5302", "Highway Engineering Design" },
                    { 17, "CE5204", "Structural Analysis III" },
                    { 18, "CE5251", "Design of Timber and Masonry Structures (TE)" },
                    { 19, "CE5252", "Graphical User Interface Programming (TE)" },
                    { 20, "CE5253", "Infrastructure Planning (TE)" },
                    { 21, "CE5254", "Integrated Solid Waste Management (TE)" },
                    { 22, "CE5255", "Remote Sensing and GIS (TE)" },
                    { 23, "CE6301", "Construction Processes and Technology" },
                    { 24, "CE6302", "Design of Concrete structures II" },
                    { 16, "CE5303", "Hydraulic Engineering" },
                    { 92, "EE8202", "Electrical Systems in Buildings (TE)" },
                    { 48, "EE2201", "Object Oriented Programming" },
                    { 50, "EE3301", "Analog Electronics" },
                    { 73, "EE6303", "Electric Machines and Drives" },
                    { 74, "EE6304", "Embedded System Design" },
                    { 75, "EE6205", "Energy and Environment" },
                    { 76, "EE6206", "Operating Systems Programming (TE)" },
                    { 77, "EE6207", "Wireless and Mobile Communication (TE)" },
                    { 78, "EE7601", "Undergraduate Project" },
                    { 79, "EE7202", "Power Electronic Applications (TE)" },
                    { 80, "EE7203", "Power System Analysis (TE)" },
                    { 72, "EE6302", "Control System Design" },
                    { 81, "EE7204", "Scientific Computing (TE)" },
                    { 83, "EE7206", "Mobile Application Development (TE)" },
                    { 84, "EE7206", "Machine Learning (TE)" },
                    { 85, "EE7207", "Computer Vision and Image Processing (TE)" },
                    { 86, "EE7208", "Advanced Data Communication (TE)" },
                    { 4, "CE3301", "Building Planning and Cost Estimating" },
                    { 88, "EE7210", "Telecommunication Networks (TE)" },
                    { 89, "EE7211", "Optical Fiber Communication (TE)" },
                    { 90, "EE7212", "EE 7212 Introduction to Research (TE)" },
                    { 82, "EE7205", "Object Oriented Design Patterns and Principles (TE)" },
                    { 49, "EE2202", "Introduction to Electronic Engineering" },
                    { 71, "EE6301", "Communication Systems" },
                    { 69, "EE5207", "Internet Technologies (TE)" },
                    { 51, "EE3302", "Engineering Electromagnetism" },
                    { 52, "EE3303", "Electric Machines" },
                    { 53, "EE3204", "Graphical User Interface Programming" },
                    { 54, "EE3205", "Signals and Systems" },
                    { 55, "EE3207", "Planning and Management for Electrical Engineers (TE)" },
                    { 56, "EE3108", "Electronic Project" },
                    { 57, "EE4301", "Communication Theory" },
                    { 58, "EE4302", "Digital Electronics" },
                    { 70, "EE5208", "Electronic Circuit Design (TE)" },
                    { 59, "EE4303", "Data Structures and Algorithms" },
                    { 61, "EE4305", "Power Systems" },
                    { 62, "EE4106", "Software Engineering Principles" },
                    { 63, "EE5201", "Computer Architecture" },
                    { 64, "EE5302", "Computer Networks" },
                    { 65, "EE5203", "Data Management Systems" },
                    { 66, "EE5304", "Power Electronics" },
                    { 67, "EE5305", "Sensors, Transducers and Measurement Techniques" },
                    { 68, "EE5206", "Software Project" },
                    { 60, "EE4204", "Electrical and Electronic Measurements" },
                    { 87, "EE7209", "Digital Signal Processing (TE)" }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Electrical and Information Engineering Department Building" },
                    { 2, 2, "Civil and Environment Engineering Engineering Department Building" },
                    { 3, 3, "Mechanical and Manufacturing Engineering Department Building" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "BuildingId", "Name", "PermissionType" },
                values: new object[,]
                {
                    { 11, 4, "IS-CC", "isHOD" },
                    { 16, 4, " IS-Seminor ", "isHOD" },
                    { 1, 5, "DO1-A", "null" },
                    { 2, 5, "DO1-B", "null" },
                    { 3, 5, " DO2-A ", "null" },
                    { 4, 5, " DO2-B", "null" },
                    { 5, 5, "LR1", "null" },
                    { 6, 5, "LR2", "null" },
                    { 7, 5, "LT1", "null" },
                    { 8, 5, "LT2", "null" },
                    { 9, 5, "NLH1", "null" },
                    { 10, 5, "NLH2", "null" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "BuildingId", "Name", "PermissionType" },
                values: new object[,]
                {
                    { 12, 1, "ELEC-CC", "elecHOD" },
                    { 13, 1, "ELR", " elecHOD " },
                    { 14, 2, "CLR", "civilHOD" },
                    { 15, 3, "MLR", "mechHOD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_DepartmentId",
                table: "Buildings",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HodId",
                table: "Departments",
                column: "HodId");

            migrationBuilder.CreateIndex(
                name: "IX_Halls_BuildingId",
                table: "Halls",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSessions_SubjectId",
                table: "OnlineSessions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineSessions_UserId",
                table: "OnlineSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_HallId",
                table: "Sessions",
                column: "HallId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_SubjectId",
                table: "Sessions",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_UserId",
                table: "Sessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUsers_SubjectId",
                table: "SubjectUsers",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectUsers_UserId",
                table: "SubjectUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentId",
                table: "Users",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "OnlineSessions");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "SubjectUsers");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Hods");
        }
    }
}
