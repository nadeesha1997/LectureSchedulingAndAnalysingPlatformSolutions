using Microsoft.EntityFrameworkCore.Migrations;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    public partial class subjecthallsdatabaseupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "2a4671a7-1d6a-4a17-b911-9f96db9271e9");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "6ea5a969-66d2-453d-a140-4a06cea886a4");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "c6c8fe23-6442-466c-82ec-acc1ba184aa2");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "ca66a7cd-ca08-4007-8382-2ad1c723db27");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "f0bb29f1-06bd-42ec-8018-3c72d7f3bf2d");

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 5, "DO1-A", "null" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 5, "DO1-B", "null" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 5, " DO2-A ", "null" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 5, " DO2-B", "null" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PermissionType" },
                values: new object[] { "LR1", "null" });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "BuildingId", "Name", "PermissionType" },
                values: new object[,]
                {
                    { 16, 4, " IS-Seminor ", "isHOD" },
                    { 15, 3, "MLR", "mechHOD" },
                    { 14, 2, "CLR", "civilHOD" },
                    { 6, 5, "LR2", "null" },
                    { 12, 1, "ELEC-CC", "elecHOD" },
                    { 10, 5, "NLH2", "null" },
                    { 9, 5, "NLH1", "null" },
                    { 13, 1, "ELR", " elecHOD " },
                    { 7, 5, "LT1", "null" },
                    { 8, 5, "LT2", "null" },
                    { 11, 4, "IS-CC", "isHOD" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b6046ef1-68ec-4946-b6ae-136e89d4a02a", "77e5c074-b95a-40e6-8dc4-a8e2e4dbd309", "HOD", "HOD" },
                    { "7269c841-7064-43f0-a5b6-228a1820405f", "5fe27e68-0395-4180-9e68-24bbe2441705", "AR", "AR" },
                    { "93c52557-5798-46e8-9e80-16a44a6e9267", "de0e9942-18e1-48dc-bba1-d34be592c793", "Admin", "ADMIN" },
                    { "1c73d407-cc71-487a-98ca-01b852d4aa76", "7342e931-7a4d-40b2-8908-6f144c98b349", "Student", "STUDENT" },
                    { "34d2c848-ce0b-45ad-9902-1969b54ff7d8", "6239cc49-6703-4c63-a2f4-03f7972433de", "Teacher", "TEACHER" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "CE1301");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "CE2302");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "CE2201");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE3301", "Building Planning and Cost Estimating" });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: "CE3202");

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 124, "ME5312", "Marine Engineering Knowledge (TE)" },
                    { 120, "ME5302", "Electrical Power and Machines" },
                    { 122, "ME5304", "Refrigeration and Air Conditioning" },
                    { 121, "ME5303", "Mechanical Engineering Design" },
                    { 125, "ME5113", "Technical Report Writing (TE)" },
                    { 123, "ME5311", "Mechatronics (TE)" },
                    { 126, "ME5214", "Advanced Automobile Engineering (TE)" },
                    { 131, "ME6211", "Nanotechnology (TE)" },
                    { 128, "ME6302", "Automatic Control Engineering" },
                    { 129, "ME6303", "Computer Aided Manufacturing" },
                    { 130, "ME6304", "Production Planning and control" },
                    { 119, "ME5301", "Computer Aided Design" },
                    { 132, "ME6312", "Robotics (TE)" },
                    { 133, "ME6213", "Research Methodology and Ethics (TE)" },
                    { 134, "ME6114", "Technical Presentation Skills (TE)" },
                    { 127, "ME6301", "Advanced Fluid Mechanics" },
                    { 118, "ME4312", "Automobile Engineering (TE)" },
                    { 112, "ME3111", "Engineering Design Methodology (TE)" },
                    { 116, "ME4304", "Mechanics of Machines" },
                    { 100, "EE8210", "Digital Communication (TE)" },
                    { 101, "EE8211", "Design and Management of Data Networks (TE)" },
                    { 102, "EE8212", "Biomedical Engineering (TE)" },
                    { 103, "EE8213", "Photonic Devices (TE)" },
                    { 104, "EE8115", "Introduction to Hardware Description Languages (TE)" },
                    { 105, "EE8117", "Video Compression and Communication (TE)" },
                    { 106, "ME1202", "Fundamentals of Engineering Thermodynamics" },
                    { 117, "ME4311", "Analog and Digital Electronics (TE)" },
                    { 107, "ME2302", "Introduction to Materials Science and Manufacturing Engineering" },
                    { 109, "ME3302", "Metallurgy for Engineers" },
                    { 110, "ME3303", "Modelling of Dynamic Systems" },
                    { 111, "ME3304", "Strength of Materials" },
                    { 135, "ME7301", "Maintenance Management" },
                    { 113, "ME4301", "Applied Thermodynamics" },
                    { 114, "ME4302", "Design of Machine Elements" },
                    { 115, "ME4303", "Manufacturing Engineering" },
                    { 108, "ME3301", "Fluid Mechanics" },
                    { 136, "ME7302", "Production and Operations Management" },
                    { 142, "ME7314", "Polymer Technology (TE)" },
                    { 138, "ME7604", "Undergraduate Project" },
                    { 160, "IS4302", "Technology and Society (GE)" },
                    { 161, "IS4103", "Appreciation of Music (GE)" },
                    { 162, "IS4104", "Digital Modelling and Animation (GE)" },
                    { 163, "IS4205", "Aesthetics and Design (GE)" },
                    { 164, "IS4106", "Spiritual Development (GE)" },
                    { 165, "IS5301", "Numerical Methods" },
                    { 166, "IS5202", "Industrial Safety and Resource Management (GE)" },
                    { 159, "IS4301", "Probability and Statistics" },
                    { 167, "IS5303", "Financial Management (GE)" },
                    { 169, "IS5205", "Information Literacy and Scientific Communication Skills (GE)" },
                    { 170, "IS6301", "Mathematical Modelling " },
                    { 171, "IS6202", "Introduction to Sociology (GE)" },
                    { 172, "IS6203", "Entrepreneurship and Project Management (GE)" },
                    { 173, "IS6304", "Management and Organizational Behavior (GE)" },
                    { 174, "IS7101", "Engineering Ethics (GE)" },
                    { 175, "IS8201", "English for the Professional World (GE)" },
                    { 168, "IS5304", "Industrial Management (GE)" },
                    { 137, "ME7303", "Solid Mechanics " },
                    { 158, "IS3207", "Introduction to Astronomy (GE)" },
                    { 156, "IS3105", "Creative Dance and Oriental Ballet (GE)" },
                    { 139, "ME7311", "Advanced Marine Engineering (TE)" },
                    { 140, "ME7312", "Energy Technology (TE)" },
                    { 141, "ME7313", "Industrial Automation and Control (TE)" },
                    { 143, "ME8301", "Heat Transfer" },
                    { 99, "EE8209", "Microwave Communications (TE)" },
                    { 145, "ME8311", "Aerospace Engineering (TE)" },
                    { 146, "ME8312", "Energy Management (TE)" },
                    { 157, "IS3206", "Physical Development and Health Management (GE)" },
                    { 147, "EE8212", "Biomedical Engineering (TE)" },
                    { 149, "IS1302", "Communication for Engineers" },
                    { 150, "IS1401", "Mathematical Fundamentals for Engineers" },
                    { 151, "IS2401", "Linear Algebra and Differential Equations" },
                    { 152, "IS3301", "Complex Analysis and Mathematical Transforms" },
                    { 153, "IS3302", "Society and the Engineer (GE)" },
                    { 154, "IS3303", "Basic Economics (GE)" },
                    { 155, "IS3104", "Graphic Design (GE)" },
                    { 148, "ME8213", "Individual Research Project (TE)" },
                    { 144, "ME8302", "Industrial Fluid Dynamics" },
                    { 97, "EE8207 ", "Optimization Techniques for Engineers (TE)" },
                    { 96, "EE8206 ", "Computer Graphics (TE)" },
                    { 29, "CE6251", "Building Services Engineering (TE)" },
                    { 30, "CE6252", "Dynamic & Control of Structures (TE)" },
                    { 31, "CE6253", "Ecological Engineering (TE)" },
                    { 32, "CE6254", "Coastal Engineering (TE)" },
                    { 33, "CE7301", "Construction Management" },
                    { 34, "CE7402", "Comprehensive Design Project" },
                    { 35, "CE7203", "Computer Analysis of Structures" },
                    { 36, "CE7304", "Environmental Management" },
                    { 37, "CE7305", "Geotechnical Engineering Design" },
                    { 38, "CE7206", "Introduction to Research Methodology" },
                    { 39, "CE7607", "Undergraduate Research Project" },
                    { 40, "CE7251", "Coastal Engineering – Application and Management (TE)" },
                    { 41, "CE7252", "Ground Improvement Techniques (TE)" },
                    { 42, "CE7253", "Highway Maintenance and Management (TE)" },
                    { 43, "CE7254", "Water Reclamation and Reuse (TE)" },
                    { 44, "CE8252", "Irrigation and Watershed Management (TE)" },
                    { 45, "CE8253", "Water Resource Planning and Management (TE)" },
                    { 46, "CE8254", "Analysis and Design of Large Structures for Dynamic Loadings (TE)" },
                    { 47, "EE1102", "Introduction to Programming" },
                    { 28, "CE6106", "Surveying Work Camp" },
                    { 48, "EE2201", "Object Oriented Programming" },
                    { 27, "CE6305", "Geotechnical Engineering" },
                    { 25, "CE6303", "Engineering Hydrology" },
                    { 6, "CE3203", "Engineering Surveying" },
                    { 7, "CE3304", "Fluid Mechanics" },
                    { 8, "CE3205", "Structural Analysis I" },
                    { 9, "CE4301", "Design of Concrete Structures I" },
                    { 10, "CE4302", "Engineering Geology and Soil Mechanics" },
                    { 11, "CE4203", "Structural Analysis II" },
                    { 12, "CE4304", "Transportation Engineering" },
                    { 13, "CE4305", "Water and Wastewater Engineering CE4305" },
                    { 14, "CE5201", "Design of Steel Structures" },
                    { 15, "CE5302", "Highway Engineering Design" },
                    { 16, "CE5303", "Hydraulic Engineering" },
                    { 17, "CE5204", "Structural Analysis III" },
                    { 18, "CE5251", "Design of Timber and Masonry Structures (TE)" },
                    { 19, "CE5252", "Graphical User Interface Programming (TE)" },
                    { 20, "CE5253", "Infrastructure Planning (TE)" },
                    { 21, "CE5254", "Integrated Solid Waste Management (TE)" },
                    { 22, "CE5255", "Remote Sensing and GIS (TE)" },
                    { 23, "CE6301", "Construction Processes and Technology" },
                    { 24, "CE6302", "Design of Concrete structures II" },
                    { 26, "CE6304", "Environmental Engineering Design" },
                    { 49, "EE2202", "Introduction to Electronic Engineering" },
                    { 50, "EE3301", "Analog Electronics" },
                    { 51, "EE3302", "Engineering Electromagnetism" },
                    { 76, "EE6206", "Operating Systems Programming (TE)" },
                    { 77, "EE6207", "Wireless and Mobile Communication (TE)" },
                    { 78, "EE7601", "Undergraduate Project" },
                    { 79, "EE7202", "Power Electronic Applications (TE)" },
                    { 80, "EE7203", "Power System Analysis (TE)" },
                    { 81, "EE7204", "Scientific Computing (TE)" },
                    { 82, "EE7205", "Object Oriented Design Patterns and Principles (TE)" },
                    { 83, "EE7206", "Mobile Application Development (TE)" },
                    { 84, "EE7206", "Machine Learning (TE)" },
                    { 85, "EE7207", "Computer Vision and Image Processing (TE)" },
                    { 86, "EE7208", "Advanced Data Communication (TE)" },
                    { 87, "EE7209", "Digital Signal Processing (TE)" },
                    { 88, "EE7210", "Telecommunication Networks (TE)" },
                    { 89, "EE7211", "Optical Fiber Communication (TE)" },
                    { 90, "EE7212", "EE 7212 Introduction to Research (TE)" },
                    { 91, "EE8301", "High Voltage Engineering (TE)" },
                    { 93, "EE8203", "High Performance Computing (TE)" },
                    { 94, "EE8204", "Information Security (TE)" },
                    { 95, "EE8205 ", "Software Architecture (TE)" },
                    { 75, "EE6205", "Energy and Environment" },
                    { 74, "EE6304", "Embedded System Design" },
                    { 73, "EE6303", "Electric Machines and Drives" },
                    { 72, "EE6302", "Control System Design" },
                    { 52, "EE3303", "Electric Machines" },
                    { 53, "EE3204", "Graphical User Interface Programming" },
                    { 54, "EE3205", "Signals and Systems" },
                    { 55, "EE3207", "Planning and Management for Electrical Engineers (TE)" },
                    { 56, "EE3108", "Electronic Project" },
                    { 57, "EE4301", "Communication Theory" },
                    { 58, "EE4302", "Digital Electronics" },
                    { 59, "EE4303", "Data Structures and Algorithms" },
                    { 60, "EE4204", "Electrical and Electronic Measurements" },
                    { 98, "EE8208", "Intelligent Systems Design (TE)" },
                    { 61, "EE4305", "Power Systems" },
                    { 63, "EE5201", "Computer Architecture" },
                    { 64, "EE5302", "Computer Networks" },
                    { 65, "EE5203", "Data Management Systems" },
                    { 66, "EE5304", "Power Electronics" },
                    { 67, "EE5305", "Sensors, Transducers and Measurement Techniques" },
                    { 68, "EE5206", "Software Project" },
                    { 69, "EE5207", "Internet Technologies (TE)" },
                    { 70, "EE5208", "Electronic Circuit Design (TE)" },
                    { 71, "EE6301", "Communication Systems" },
                    { 62, "EE4106", "Software Engineering Principles" },
                    { 92, "EE8202", "Electrical Systems in Buildings (TE)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "1c73d407-cc71-487a-98ca-01b852d4aa76");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "34d2c848-ce0b-45ad-9902-1969b54ff7d8");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "7269c841-7064-43f0-a5b6-228a1820405f");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "93c52557-5798-46e8-9e80-16a44a6e9267");

            migrationBuilder.DeleteData(
                table: "IdentityRole",
                keyColumn: "Id",
                keyValue: "b6046ef1-68ec-4946-b6ae-136e89d4a02a");

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 1, "ELR", "elecHOD" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 1, "EIE Computer Lab", "elecHOD" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 3, "MLR", "mechHOD" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BuildingId", "Name", "PermissionType" },
                values: new object[] { 2, "CLR", "civilHOD" });

            migrationBuilder.UpdateData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "PermissionType" },
                values: new object[] { "LT1", null });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f0bb29f1-06bd-42ec-8018-3c72d7f3bf2d", "f2cfc5e3-44ac-41ae-866d-fe97c0068658", "Teacher", "TEACHER" },
                    { "2a4671a7-1d6a-4a17-b911-9f96db9271e9", "f54da98a-8ca3-413f-9630-1fde92b36f6f", "Student", "STUDENT" },
                    { "6ea5a969-66d2-453d-a140-4a06cea886a4", "32106cbd-3143-411d-b92c-a977a10e6c7d", "Admin", "ADMIN" },
                    { "c6c8fe23-6442-466c-82ec-acc1ba184aa2", "c235830e-3c22-4658-98d9-4d99cb3730bc", "AR", "AR" },
                    { "ca66a7cd-ca08-4007-8382-2ad1c723db27", "17e4bf2b-d94a-44c7-8f42-cf15973fcf29", "HOD", "HOD" }
                });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1,
                column: "Code",
                value: "CE1301 ");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Code",
                value: "CE2302 ");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3,
                column: "Code",
                value: "CE2201 ");

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Code", "Name" },
                values: new object[] { "CE3301 ", "Building Planning and Cost Estimating " });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5,
                column: "Code",
                value: "CE3202 ");
        }
    }
}
