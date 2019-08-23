using Microsoft.EntityFrameworkCore.Migrations;

namespace DXC.LM.Core.ReferenceDataAPI.Endpoints.Migrations
{
    public partial class SeedCoB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ReferenceDataItems",
                columns: new[] { "ID", "Key", "Path", "Value" },
                values: new object[,]
                {
                    {4478,"1","COBRiskCodes:HighLevel","Accident & Health"},
                    {4479,"2","COBRiskCodes:HighLevel","Aviation"},
                    {4480,"3","COBRiskCodes:HighLevel","Casualty Other"},
                    {4481,"4","COBRiskCodes:HighLevel","Casualty Treaty"},
                    {4482,"5","COBRiskCodes:HighLevel","Energy"},
                    {4483,"6","COBRiskCodes:HighLevel","FinPro Casualty"},
                    {4484,"7","COBRiskCodes:HighLevel","Marine"},
                    {4485,"8","COBRiskCodes:HighLevel","Other Casualty"},
                    {4486,"9","COBRiskCodes:HighLevel","Other Specialty"},
                    {4487,"10","COBRiskCodes:HighLevel","Property (D&F)"},
                    {4488,"11","COBRiskCodes:HighLevel","Property Treaty"},
                    {4489,"1","COBRiskCodes:Generic","Accident & Health (direct)"},
                    {4490,"2","COBRiskCodes:Generic","Medical Expenses"},
                    {4491,"3","COBRiskCodes:Generic","Personal Accident XL"},
                    {4492,"4","COBRiskCodes:Generic","Pecuniary"},
                    {4493,"5","COBRiskCodes:Generic","Contingency"},
                    {4494,"6","COBRiskCodes:Generic","Term Life"},
                    {4495,"7","COBRiskCodes:Generic","Aviation Products/ Airport Liabilities"},
                    {4496,"8","COBRiskCodes:Generic","Aviation War"},
                    {4497,"9","COBRiskCodes:Generic","Airline"},
                    {4498,"10","COBRiskCodes:Generic","General Aviation"},
                    {4499,"11","COBRiskCodes:Generic","Space"},
                    {4500,"12","COBRiskCodes:Generic","Aviation XL"},
                    {4501,"13","COBRiskCodes:Generic","NM General Liability (non-US direct)"},
                    {4502,"14","COBRiskCodes:Generic","NM General Liability (US direct)"},
                    {4503,"15","COBRiskCodes:Generic","Employers Liability/ WCA (US)"},
                    {4504,"16","COBRiskCodes:Generic","Casualty Treaty (US)"},
                    {4505,"17","COBRiskCodes:Generic","Casualty Treaty (non-US)"},
                    {4506,"18","COBRiskCodes:Generic","Motor XL"},
                    {4507,"19","COBRiskCodes:Generic","Energy Onshore Liability"},
                    {4508,"20","COBRiskCodes:Generic","Energy Construction"},
                    {4509,"21","COBRiskCodes:Generic","Energy Onshore Property"},
                    {4510,"22","COBRiskCodes:Generic","Energy Offshore Liability"},
                    {4511,"23","COBRiskCodes:Generic","Energy Offshore Property"},
                    {4512,"24","COBRiskCodes:Generic","Nuclear"},
                    {4513,"25","COBRiskCodes:Generic","Power Generation"},
                    {4514,"26","COBRiskCodes:Generic","BBB/ Crime"},
                    {4515,"27","COBRiskCodes:Generic","Cyber"},
                    {4516,"28","COBRiskCodes:Generic","Directors & Officers (US)"},
                    {4517,"29","COBRiskCodes:Generic","Directors & Officers (non-US)"},
                    {4518,"30","COBRiskCodes:Generic","Financial Institutions (US)"},
                    {4519,"31","COBRiskCodes:Generic","Financial Institutions (non-US)"},
                    {4520,"32","COBRiskCodes:Generic","Professional Indemnity (US)"},
                    {4521,"33","COBRiskCodes:Generic","Professional Indemnity (non-US)"},
                    {4522,"34","COBRiskCodes:Generic","Marine Hull"},
                    {4523,"35","COBRiskCodes:Generic","Specie"},
                    {4524,"36","COBRiskCodes:Generic","Fine Art"},
                    {4525,"37","COBRiskCodes:Generic","Marine Liability"},
                    {4526,"38","COBRiskCodes:Generic","Marine XL"},
                    {4527,"39","COBRiskCodes:Generic","Yacht"},
                    {4528,"40","COBRiskCodes:Generic","Marine War"},
                    {4529,"41","COBRiskCodes:Generic","Cargo"},
                    {4530,"42","COBRiskCodes:Generic","NM General Liability (non-US direct)"},
                    {4531,"43","COBRiskCodes:Generic","Medical Malpractice"},
                    {4532,"44","COBRiskCodes:Generic","UK Motor"},
                    {4533,"45","COBRiskCodes:Generic","Overseas Motor"},
                    {4534,"46","COBRiskCodes:Generic","RITC"},
                    {4535,"47","COBRiskCodes:Generic","NM General Liability (US direct)"},
                    {4536,"48","COBRiskCodes:Generic","Employers Liability/ WCA (non-US)"},
                    {4537,"49","COBRiskCodes:Generic","Terrorism"},
                    {4538,"50","COBRiskCodes:Generic","Engineering"},
                    {4539,"51","COBRiskCodes:Generic","Political Risks, Credit & Financial Guarantee"},
                    {4540,"52","COBRiskCodes:Generic","Legal Expenses"},
                    {4541,"53","COBRiskCodes:Generic","Livestock & Bloodstock"},
                    {4542,"54","COBRiskCodes:Generic","Extended Warranty"},
                    {4543,"55","COBRiskCodes:Generic","Property D&F (US binder)"},
                    {4544,"56","COBRiskCodes:Generic","Property D&F (non-US binder)"},
                    {4545,"57","COBRiskCodes:Generic","Difference in Conditions"},
                    {4546,"58","COBRiskCodes:Generic","Property D&F (US open market)"},
                    {4547,"59","COBRiskCodes:Generic","Property D&F (non-US open market)"},
                    {4548,"60","COBRiskCodes:Generic","Agriculture & Hail"},
                    {4549,"61","COBRiskCodes:Generic","Property pro rata"},
                    {4550,"62","COBRiskCodes:Generic","Property Cat XL (Non-US)"},
                    {4551,"63","COBRiskCodes:Generic","Property Cat XL (US)"},
                    {4552,"64","COBRiskCodes:Generic","Property Risk XS"},
                    {4553,"1","COBRiskCodes:HighLevel:1:Generic","Accident & Health (direct)"},
                    {4554,"2","COBRiskCodes:HighLevel:1:Generic","Medical Expenses"},
                    {4555,"3","COBRiskCodes:HighLevel:1:Generic","Personal Accident XL"},
                    {4556,"4","COBRiskCodes:HighLevel:1:Generic","Pecuniary"},
                    {4557,"5","COBRiskCodes:HighLevel:1:Generic","Contingency"},
                    {4558,"6","COBRiskCodes:HighLevel:1:Generic","Term Life"},
                    {4559,"7","COBRiskCodes:HighLevel:2:Generic","Aviation Products/ Airport Liabilities"},
                    {4560,"8","COBRiskCodes:HighLevel:2:Generic","Aviation War"},
                    {4561,"9","COBRiskCodes:HighLevel:2:Generic","Airline"},
                    {4562,"10","COBRiskCodes:HighLevel:2:Generic","General Aviation"},
                    {4563,"11","COBRiskCodes:HighLevel:2:Generic","Space"},
                    {4564,"12","COBRiskCodes:HighLevel:2:Generic","Aviation XL"},
                    {4565,"13","COBRiskCodes:HighLevel:3:Generic","NM General Liability (non-US direct)"},
                    {4566,"14","COBRiskCodes:HighLevel:3:Generic","NM General Liability (US direct)"},
                    {4567,"15","COBRiskCodes:HighLevel:4:Generic","Employers Liability/ WCA (US)"},
                    {4568,"16","COBRiskCodes:HighLevel:4:Generic","Casualty Treaty (US)"},
                    {4569,"17","COBRiskCodes:HighLevel:4:Generic","Casualty Treaty (non-US)"},
                    {4570,"18","COBRiskCodes:HighLevel:4:Generic","Motor XL"},
                    {4571,"19","COBRiskCodes:HighLevel:5:Generic","Energy Onshore Liability"},
                    {4572,"20","COBRiskCodes:HighLevel:5:Generic","Energy Construction"},
                    {4573,"21","COBRiskCodes:HighLevel:5:Generic","Energy Onshore Property"},
                    {4574,"22","COBRiskCodes:HighLevel:5:Generic","Energy Offshore Liability"},
                    {4575,"23","COBRiskCodes:HighLevel:5:Generic","Energy Offshore Property"},
                    {4576,"24","COBRiskCodes:HighLevel:5:Generic","Nuclear"},
                    {4577,"25","COBRiskCodes:HighLevel:5:Generic","Power Generation"},
                    {4578,"26","COBRiskCodes:HighLevel:6:Generic","BBB/ Crime"},
                    {4579,"27","COBRiskCodes:HighLevel:6:Generic","Cyber"},
                    {4580,"28","COBRiskCodes:HighLevel:6:Generic","Directors & Officers (US)"},
                    {4581,"29","COBRiskCodes:HighLevel:6:Generic","Directors & Officers (non-US)"},
                    {4582,"30","COBRiskCodes:HighLevel:6:Generic","Financial Institutions (US)"},
                    {4583,"31","COBRiskCodes:HighLevel:6:Generic","Financial Institutions (non-US)"},
                    {4584,"32","COBRiskCodes:HighLevel:6:Generic","Professional Indemnity (US)"},
                    {4585,"33","COBRiskCodes:HighLevel:6:Generic","Professional Indemnity (non-US)"},
                    {4586,"34","COBRiskCodes:HighLevel:7:Generic","Marine Hull"},
                    {4587,"35","COBRiskCodes:HighLevel:7:Generic","Specie"},
                    {4588,"36","COBRiskCodes:HighLevel:7:Generic","Fine Art"},
                    {4589,"37","COBRiskCodes:HighLevel:7:Generic","Marine Liability"},
                    {4590,"38","COBRiskCodes:HighLevel:7:Generic","Marine XL"},
                    {4591,"39","COBRiskCodes:HighLevel:7:Generic","Yacht"},
                    {4592,"40","COBRiskCodes:HighLevel:7:Generic","Marine War"},
                    {4593,"41","COBRiskCodes:HighLevel:7:Generic","Cargo"},
                    {4594,"42","COBRiskCodes:HighLevel:8:Generic","NM General Liability (non-US direct)"},
                    {4595,"43","COBRiskCodes:HighLevel:8:Generic","Medical Malpractice"},
                    {4596,"44","COBRiskCodes:HighLevel:8:Generic","UK Motor"},
                    {4597,"45","COBRiskCodes:HighLevel:8:Generic","Overseas Motor"},
                    {4598,"46","COBRiskCodes:HighLevel:8:Generic","RITC"},
                    {4599,"47","COBRiskCodes:HighLevel:8:Generic","NM General Liability (US direct)"},
                    {4600,"48","COBRiskCodes:HighLevel:8:Generic","Employers Liability/ WCA (non-US)"},
                    {4601,"49","COBRiskCodes:HighLevel:9:Generic","Terrorism"},
                    {4602,"50","COBRiskCodes:HighLevel:9:Generic","Engineering"},
                    {4603,"51","COBRiskCodes:HighLevel:9:Generic","Political Risks, Credit & Financial Guarantee"},
                    {4604,"52","COBRiskCodes:HighLevel:9:Generic","Legal Expenses"},
                    {4605,"53","COBRiskCodes:HighLevel:9:Generic","Livestock & Bloodstock"},
                    {4606,"54","COBRiskCodes:HighLevel:9:Generic","Extended Warranty"},
                    {4607,"55","COBRiskCodes:HighLevel:10:Generic","Property D&F (US binder)"},
                    {4608,"56","COBRiskCodes:HighLevel:10:Generic","Property D&F (non-US binder)"},
                    {4609,"57","COBRiskCodes:HighLevel:10:Generic","Difference in Conditions"},
                    {4610,"58","COBRiskCodes:HighLevel:10:Generic","Property D&F (US open market)"},
                    {4611,"59","COBRiskCodes:HighLevel:10:Generic","Property D&F (non-US open market)"},
                    {4612,"60","COBRiskCodes:HighLevel:11:Generic","Agriculture & Hail"},
                    {4613,"61","COBRiskCodes:HighLevel:11:Generic","Property pro rata"},
                    {4614,"62","COBRiskCodes:HighLevel:11:Generic","Property Cat XL (Non-US)"},
                    {4615,"63","COBRiskCodes:HighLevel:11:Generic","Property Cat XL (US)"},
                    {4616,"64","COBRiskCodes:HighLevel:11:Generic","Property Risk XS"},
                    {4617,"1E","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE PROPERTY"},
                    {4618,"1T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM ACCIDENT AND HEALTH"},
                    {4619,"2E","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE LIABILITY"},
                    {4620,"2T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM AVIATION"},
                    {4621,"3E","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE PROPERTY"},
                    {4622,"3T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM MARINE"},
                    {4623,"4E","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE LIABILITY"},
                    {4624,"4T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM MISC AND PECUNIARY LOSS"},
                    {4625,"5T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM MOTOR"},
                    {4626,"6T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM PROPERTY"},
                    {4627,"7T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM THIRD PARTY LIABILITY"},
                    {4628,"8T","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS LEG TERRORISM TRANSPORT"},
                    {4629,"AG","COBRiskCodes:HighLevel:11:Generic:60:Description","AGRICULTURAL CROP AND FORESTRY XOL TREATY INCL STOP LOSS"},
                    {4630,"AO","COBRiskCodes:HighLevel:2:Generic:7:Description","AVIATION PREMISES LEGAL LIABILITY NO PRODUCTS"},
                    {4631,"AP","COBRiskCodes:HighLevel:2:Generic:7:Description","AVIATION OR AEROSPACE PRODUCTS LEGAL LIABILITY"},
                    {4632,"AW","COBRiskCodes:HighLevel:2:Generic:8:Description","HULLS OF AIRCRAFT WAR OR CONFISCATION NO ACV"},
                    {4633,"B","COBRiskCodes:HighLevel:7:Generic:34:Description","Vessels TLO IV LOH and Containers Excl. WRO"},
                    {4634,"B2","COBRiskCodes:HighLevel:10:Generic:55:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY IN USA"},
                    {4635,"B3","COBRiskCodes:HighLevel:10:Generic:55:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY IN USA"},
                    {4636,"B4","COBRiskCodes:HighLevel:10:Generic:56:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY EXCL USA"},
                    {4637,"B5","COBRiskCodes:HighLevel:10:Generic:56:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY EXCL USA"},
                    {4638,"BB","COBRiskCodes:HighLevel:6:Generic:26:Description","FIDELITY COMPUTER CRIME AND BANKERS POLICIES"},
                    {4639,"BD","COBRiskCodes:HighLevel:9:Generic:49:Description","TERRORISM POOL RE"},
                    {4640,"CB","COBRiskCodes:HighLevel:9:Generic:50:Description","ENGINEERING ANNUAL RENEWABLE INCL CAR EAR MB CPE B&M EEI AND TREATY LOD"},
                    {4641,"CC","COBRiskCodes:HighLevel:9:Generic:50:Description","ENGINEERING SINGLE PROJECT NON RENEWABLE INCL CAR EAR AND TREATY RAD"},
                    {4642,"CF","COBRiskCodes:HighLevel:9:Generic:51:Description","CONTRACT FRUSTRATION FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {4643,"CR","COBRiskCodes:HighLevel:9:Generic:51:Description","CREDIT RISK FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {4644,"CT","COBRiskCodes:HighLevel:7:Generic:35:Description","ARMOURED CARRIERS AND CASH IN TRANSIT"},
                    {4645,"CY","COBRiskCodes:HighLevel:6:Generic:27:Description","Cyber Security Data and Privacy Breach"},
                    {4646,"CZ","COBRiskCodes:HighLevel:6:Generic:27:Description","CYBER SECURITY AND PROPERTY DAMAGE"},
                    {4647,"D2","COBRiskCodes:HighLevel:6:Generic:28:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS IN USA"},
                    {4648,"D3","COBRiskCodes:HighLevel:6:Generic:29:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS EXCL USA "},
                    {4649,"D4","COBRiskCodes:HighLevel:6:Generic:30:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS INCL USA"},
                    {4650,"D5","COBRiskCodes:HighLevel:6:Generic:31:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS EXCL USA"},
                    {4651,"D6","COBRiskCodes:HighLevel:6:Generic:28:Description","Employment Practices Liability Insurance (EPLI) Incl. US"},
                    {4652,"D7","COBRiskCodes:HighLevel:6:Generic:29:Description","Employment Practices Liability Insurance (EPLI) Excl. US"},
                    {4653,"D8","COBRiskCodes:HighLevel:6:Generic:28:Description","Transactional Liability insurance Incl. US"},
                    {4654,"D9","COBRiskCodes:HighLevel:6:Generic:29:Description","Transactional Liability insurance Excl. US"},
                    {4655,"DC","COBRiskCodes:HighLevel:10:Generic:57:Description","DIFFERENCE IN CONDITIONS"},
                    {4656,"E2","COBRiskCodes:HighLevel:6:Generic:32:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS INCL USA"},
                    {4657,"E3","COBRiskCodes:HighLevel:6:Generic:33:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS EXCL USA"},
                    {4658,"E4","COBRiskCodes:HighLevel:6:Generic:32:Description","PROF INDTY E&O FOR ACCOUNTANTS INCL USA"},
                    {4659,"E5","COBRiskCodes:HighLevel:6:Generic:33:Description","PROF INDTY E&O FOR ACCOUNTANTS EXCL USA"},
                    {4660,"E6","COBRiskCodes:HighLevel:6:Generic:32:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES INCL USA"},
                    {4661,"E7","COBRiskCodes:HighLevel:6:Generic:33:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES EXCL USA"},
                    {4662,"E8","COBRiskCodes:HighLevel:6:Generic:32:Description","MISC PROF IND E&O INCL USA EXCL \"E2\" \"E4\" \"E6\" CODES"},
                    {4663,"E9","COBRiskCodes:HighLevel:6:Generic:33:Description","MISC PROF IND E&O EXCL USA EXCL \"E3\" \"E5\" \"E7\" CODES"},
                    {4664,"EA","COBRiskCodes:HighLevel:5:Generic:19:Description","ENERGY LIABILITY ONSHORE CLAIMS MADE"},
                    {4665,"EB","COBRiskCodes:HighLevel:5:Generic:19:Description","ENERGY LIABILITY ONSHORE ALL OTHER"},
                    {4666,"EC","COBRiskCodes:HighLevel:5:Generic:20:Description","ENERGY CONSTRUCTION OFFSHORE PROP AND SEARCH PROD VSSLS EXCL WRO"},
                    {4667,"EF","COBRiskCodes:HighLevel:5:Generic:21:Description","ENERGY ONSHORE PROPERTY"},
                    {4668,"EG","COBRiskCodes:HighLevel:5:Generic:22:Description","ENERGY LIABILITY OFFSHORE CLAIMS MADE"},
                    {4669,"EH","COBRiskCodes:HighLevel:5:Generic:22:Description","ENERGY LIABILITY OFFSHORE ALL OTHER"},
                    {4670,"EM","COBRiskCodes:HighLevel:5:Generic:23:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {4671,"EN","COBRiskCodes:HighLevel:5:Generic:23:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP EXCL GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {4672,"EP","COBRiskCodes:HighLevel:8:Generic:13:Description","Environmental Impairment Liability or NM Pollution Liability"},
                    {4673,"EY","COBRiskCodes:HighLevel:5:Generic:23:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL GOM  WIND"},
                    {4674,"EZ","COBRiskCodes:HighLevel:5:Generic:23:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL EXCL GOM WIND"},
                    {4675,"F2","COBRiskCodes:HighLevel:6:Generic:30:Description","PROF INDTY E&O FOR FIN INSTITUTIONS INCL USA"},
                    {4676,"F3","COBRiskCodes:HighLevel:6:Generic:31:Description","PROF INDTY E&O FOR FIN INSTITUTIONS EXCL USA"},
                    {4677,"F4","COBRiskCodes:HighLevel:6:Generic:32:Description","Technology and Telecommunications E&O Incl. US"},
                    {4678,"F5","COBRiskCodes:HighLevel:6:Generic:33:Description","Technology and Telecommunications E&O Excl. US"},
                    {4679,"FA","COBRiskCodes:HighLevel:7:Generic:36:Description","FINE ART"},
                    {4680,"FG","COBRiskCodes:HighLevel:9:Generic:51:Description","FINANCIAL GUARANTEE (authorised syndicates only)"},
                    {4681,"FM","COBRiskCodes:HighLevel:9:Generic:51:Description","MORTGAGE INDEMNITY - From 01/01/05 also includes business previously coded \"BS\" "},
                    {4682,"G","COBRiskCodes:HighLevel:7:Generic:37:Description","MARINE LEGAL LIAB ALL OTHER NO CARGO EXCL WRO"},
                    {4683,"GC","COBRiskCodes:HighLevel:7:Generic:37:Description","MARINE LEGAL LIAB CLAIMS MADE NO CARGO EXCL WRO"},
                    {4684,"GH","COBRiskCodes:HighLevel:8:Generic:43:Description","HOSPITALS/ INSTITUTIONAL HEALTHCARE INSURANCE RISKS IN USA"},
                    {4685,"GM","COBRiskCodes:HighLevel:8:Generic:43:Description","MEDICAL MALPRACTICE EXCL USA "},
                    {4686,"GN","COBRiskCodes:HighLevel:8:Generic:43:Description","NURSING HOMES/ LONG-TERM AND ALLIED HEALTHCARE/OTHER MEDICAL MALPRACTICE RISKS IN USA"},
                    {4687,"GS","COBRiskCodes:HighLevel:7:Generic:35:Description","GENERAL SPECIE INCLUDING VAULT RISK"},
                    {4688,"GT","COBRiskCodes:HighLevel:8:Generic:43:Description","MEDICAL MALPRACTICE TREATY XOL IN USA"},
                    {4689,"GX","COBRiskCodes:HighLevel:7:Generic:38:Description","XOL MARINE LEGAL LIAB EXCL CARGO ALL OTHER EXCL WRO"},
                    {4690,"H2","COBRiskCodes:HighLevel:2:Generic:9:Description","AIRLINE HULL"},
                    {4691,"H3","COBRiskCodes:HighLevel:2:Generic:10:Description","GENERAL AVIATION HULL"},
                    {4692,"HA","COBRiskCodes:HighLevel:11:Generic:60:Description","AGRICULTURAL CROP AND FORESTRY EXCL XOL TREATY AND STOP LOSS"},
                    {4693,"HP","COBRiskCodes:HighLevel:10:Generic:56:Description","UK HOUSEHOLD BUSINESS"},
                    {4694,"JB","COBRiskCodes:HighLevel:7:Generic:35:Description","JEWELLERS BLOCK JEWELLERY ETC INCL ROBBERY - From 01/01/05 also includes business previously coded \"FR\" "},
                    {4695,"KA","COBRiskCodes:HighLevel:1:Generic:1:Description","PERSONAL ACCIDENT AND HEALTH CARVE OUT"},
                    {4696,"KB","COBRiskCodes:HighLevel:1:Generic:1:Description","DISABILITY LONG TERM BENEFIT"},
                    {4697,"KC","COBRiskCodes:HighLevel:1:Generic:1:Description","PERSONAL ACCIDENT AND HEALTH CREDITOR  DISABILITY"},
                    {4698,"KG","COBRiskCodes:HighLevel:1:Generic:1:Description","Personal Accident and Health Excl. K&R, KP KS AND KT CODES"},
                    {4699,"KM","COBRiskCodes:HighLevel:1:Generic:2:Description","MEDICAL EXPENSES INCL XS SPEC AND AGG SELF FUND"},
                    {4700,"KP","COBRiskCodes:HighLevel:1:Generic:1:Description","MARITIME EXTORTION EXCL KIDNAP AND RANSOM WRITTEN UNDER 'P'"},
                    {4701,"KS","COBRiskCodes:HighLevel:1:Generic:1:Description","PA AND HEALTH INCL SPORTS DIS OTHER THAN ACC DEATH"},
                    {4702,"KT","COBRiskCodes:HighLevel:1:Generic:1:Description","PA AND HEALTH FOR TRAVEL PACKAGE SCHEMES"},
                    {4703,"KX","COBRiskCodes:HighLevel:1:Generic:3:Description","PERSONAL ACCIDENT AND HEALTH CATASTROPHE XL - From 01/01/08 also includes business previously coded \"KL\""},
                    {4704,"L2","COBRiskCodes:HighLevel:2:Generic:9:Description","AIRLINE LIABILITY"},
                    {4705,"L3","COBRiskCodes:HighLevel:2:Generic:10:Description","GENERAL AVIATION LIABILITY"},
                    {4706,"LE","COBRiskCodes:HighLevel:9:Generic:52:Description","LEGAL EXPENSES    "},
                    {4707,"M2","COBRiskCodes:HighLevel:8:Generic:44:Description","UK MOTOR COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {4708,"M3","COBRiskCodes:HighLevel:8:Generic:44:Description","UK MOTOR COMP FOR FLEET AND COMMERCIAL VEHICLE"},
                    {4709,"M4","COBRiskCodes:HighLevel:8:Generic:44:Description","OTHER UK MOTOR COMP AND NON COMP EXCL \"M2\" AND \"M3\" CODES - From 01/01/08 includes business previously coded \"M7\""},
                    {4710,"M5","COBRiskCodes:HighLevel:8:Generic:44:Description","UK MOTOR NON COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {4711,"M6","COBRiskCodes:HighLevel:8:Generic:44:Description","UK MOTOR NON COMP FOR FLEET AND COMM VEHICLE"},
                    {4712,"MF","COBRiskCodes:HighLevel:8:Generic:45:Description","OVERSEAS MOTOR DAM AND TPL EXCL USA CAN EU AND EEA - From 01/01/05 also includes business previously coded \"MD\" and \"ME\""},
                    {4713,"MG","COBRiskCodes:HighLevel:8:Generic:45:Description","USA AND CANADA MOTOR VEHICLE PHYSICAL DAMAGE"},
                    {4714,"MH","COBRiskCodes:HighLevel:8:Generic:45:Description","USA AND CANADA MOTOR VEHICLE THIRD PARTY LIABILITY"},
                    {4715,"MI","COBRiskCodes:HighLevel:8:Generic:45:Description","USA AND CANADA MOTOR DAMAGE AND 3RD PARTY LIAB"},
                    {4716,"MP","COBRiskCodes:HighLevel:8:Generic:45:Description","EU AND EEA MOTOR PD AND TPL EXCL UK - From 01/01/05 also includes business previously coded \"MM\" and \"MN\""},
                    {4717,"N","COBRiskCodes:HighLevel:9:Generic:53:Description","LIVESTOCK"},
                    {4718,"NA","COBRiskCodes:HighLevel:8:Generic:13:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA - FROM 2019 EXCL BINDERS "},
                    {4719,"NB","COBRiskCodes:HighLevel:9:Generic:53:Description","BLOODSTOCK"},
                    {4720,"NC","COBRiskCodes:HighLevel:8:Generic:13:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA - FROM 2019 EXCL BINDERS"},
                    {4721,"NL","COBRiskCodes:HighLevel:5:Generic:24:Description","NUCLEAR LIABILITY FROM 2019 LIMITATION NOT GREATER THAN 10 YEARS"},
                    {4722,"NP","COBRiskCodes:HighLevel:5:Generic:24:Description","NUCLEAR PROPERTY DAMAGE"},
                    {4723,"NR","COBRiskCodes:HighLevel:3:Generic:13:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA -  BINDERS ONLY"},
                    {4724,"NS","COBRiskCodes:HighLevel:3:Generic:13:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA -  BINDERS ONLY"},
                    {4725,"NV","COBRiskCodes:HighLevel:5:Generic:24:Description","NUCLEAR LIABILITY LIMITATION EXCESS OF 10 YEARS"},
                    {4726,"NX","COBRiskCodes:HighLevel:9:Generic:53:Description","LIVESTOCK EXCESS OF LOSS"},
                    {4727,"O","COBRiskCodes:HighLevel:7:Generic:39:Description","YACHTS INCL WAR EXCL WRO"},
                    {4728,"P","COBRiskCodes:HighLevel:1:Generic:4:Description","MISCELLANEOUS PECUNIARY LOSS - From 01/01/05 also includes business previously coded \"PE\" \"PP\" \"PS\" and \"PW\""},
                    {4729,"P2","COBRiskCodes:HighLevel:10:Generic:58:Description","PHYS DAMAGE FOR PRIM LAYER PPTY IN USA EXCL BINDERS"},
                    {4730,"P3","COBRiskCodes:HighLevel:10:Generic:59:Description","PHYS DAMAGE FOR PRIM LAYER PPTY EXCL USA EXCL BINDERS"},
                    {4731,"P4","COBRiskCodes:HighLevel:10:Generic:58:Description","PHYS DAMAGE FOR FULL VALUE PPTY IN USA EXCL BINDERS"},
                    {4732,"P5","COBRiskCodes:HighLevel:10:Generic:59:Description","PHYS DAMAGE FOR FULL VALUE PPTY EXCL USA EXCL BINDERS"},
                    {4733,"P6","COBRiskCodes:HighLevel:10:Generic:58:Description","PHYS DAMAGE FOR XS LAYER PPTY IN USA EXCL BINDERS"},
                    {4734,"P7","COBRiskCodes:HighLevel:10:Generic:59:Description","PHYS DAMAGE FOR XS LAYER PPTY EXCL USA EXCL BINDERS"},
                    {4735,"PB","COBRiskCodes:HighLevel:1:Generic:4:Description","PRODUCT RECALL"},
                    {4736,"PC","COBRiskCodes:HighLevel:1:Generic:5:Description","CANCELLATION AND ABANDONMENT"},
                    {4737,"PF","COBRiskCodes:HighLevel:1:Generic:5:Description","FILM INCLUDING FILM COMPLETION BONDS  "},
                    {4738,"PG","COBRiskCodes:HighLevel:5:Generic:25:Description","OPERATIONAL POWER GENERATION TRANSMISSION AND UTILITIES EXCL CONSTRUCTION "},
                    {4739,"PN","COBRiskCodes:HighLevel:1:Generic:5:Description","NON APPEARANCE"},
                    {4740,"PQ","COBRiskCodes:HighLevel:8:Generic:44:Description","ROADSIDE RESCUE     "},
                    {4741,"PR","COBRiskCodes:HighLevel:9:Generic:51:Description","POLITICAL RISK EXCL CONFISCATION VESSELS AIRCRAFT"},
                    {4742,"PU","COBRiskCodes:HighLevel:1:Generic:5:Description","MISCELLANEOUS CONTINGENCY - From 01/01/05 also includes business previously coded \"PO\""},
                    {4743,"PZ","COBRiskCodes:HighLevel:1:Generic:5:Description","PRIZE INDEMNITY INCLUDING HOLE IN ONE"},
                    {4744,"Q","COBRiskCodes:HighLevel:7:Generic:40:Description","CARGO WAR AND OR CONFISCATION RISKS ONLY"},
                    {4745,"RX","COBRiskCodes:HighLevel:2:Generic:8:Description","XOL HULLS OF AIRCRAFT WAR AND OR CONFIS RISKS ONLY "},
                    {4746,"SA","COBRiskCodes:HighLevel:9:Generic:51:Description","SEAFARERS ABANDONMENT (authorised syndicates only)"},
                    {4747,"SB","COBRiskCodes:HighLevel:9:Generic:51:Description","SURETY BOND REINSURANCE - From 01/01/05 also includes business previously coded \"FC\" or \"FS\" "},
                    {4748,"SC","COBRiskCodes:HighLevel:2:Generic:11:Description","SPACE RISKS LAUNCH COMMISSIONING PERIOD AND TRANSPOND OP - From 01/01/08 also includes business previously coded \"CX\""},
                    {4749,"SL","COBRiskCodes:HighLevel:2:Generic:11:Description","SPACE RISK LIABILITY NO PRODUCTS LEGAL LIABILITY"},
                    {4750,"SO","COBRiskCodes:HighLevel:2:Generic:11:Description","SPACE RISKS TRANSPONDER OPERATING"},
                    {4751,"SR","COBRiskCodes:HighLevel:7:Generic:38:Description","AGG STOP LOSS AND XOL MARINE OUTWARD WHOLE ACCOUNT"},
                    {4752,"T","COBRiskCodes:HighLevel:7:Generic:34:Description","Vessels Excl. TLO IV LOH Containers Shipbuilding and WRO"},
                    {4753,"TC","COBRiskCodes:HighLevel:8:Generic:46:Description","COMMERCIAL RITC"},
                    {4754,"TL","COBRiskCodes:HighLevel:1:Generic:6:Description","TEMPORARY LIFE AND PERMANENT HEALTH"},
                    {4755,"TO","COBRiskCodes:HighLevel:9:Generic:49:Description","OVERSEAS STAND ALONE TERROR EXCL \"1T\" to \"8T\" & \"1E\" to \"4E\""},
                    {4756,"TR","COBRiskCodes:HighLevel:11:Generic:61:Description","ALL RISK PHYSICAL OR LOSS DAMAGE  DIRECT PPNL RI"},
                    {4757,"TS","COBRiskCodes:HighLevel:7:Generic:34:Description","SHIPBUILDING EXCL ENERGY CONSTRUCTION"},
                    {4758,"TT","COBRiskCodes:HighLevel:1:Generic:4:Description","TITLE INSURANCE"},
                    {4759,"TU","COBRiskCodes:HighLevel:9:Generic:49:Description","UK STAND ALONE TERRORISM WHICH IS NON POOL RE"},
                    {4760,"TW","COBRiskCodes:HighLevel:9:Generic:49:Description","TERRORISM AND WAR ON LAND WHOLE ACCOUNT XOL TREATY RI INCL RI OF POOLS "},
                    {4761,"TX","COBRiskCodes:HighLevel:7:Generic:38:Description","XOL VESSELS SHIPBLDG ACV LOH INCL WAR EXCL WRO - From 01/01/05 also includes business previously coded \"OX\""},
                    {4762,"UA","COBRiskCodes:HighLevel:8:Generic:14:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - FROM 2019 EXCL BINDERS"},
                    {4763,"UC","COBRiskCodes:HighLevel:8:Generic:14:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA - FROM 2019 EXCL BINDERS"},
                    {4764,"UR","COBRiskCodes:HighLevel:3:Generic:14:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - BINDERS ONLY"},
                    {4765,"US","COBRiskCodes:HighLevel:3:Generic:14:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA -  BINDERS ONLY"},
                    {4766,"V","COBRiskCodes:HighLevel:7:Generic:41:Description","CARGO ALL RISKS INCL WAR EXCL WRO"},
                    {4767,"VL","COBRiskCodes:HighLevel:7:Generic:41:Description","LEGAL LIAB CARGO AND PROP INCL CCC OF ASSURED EXCL WRO"},
                    {4768,"VX","COBRiskCodes:HighLevel:7:Generic:38:Description","XOL Cargo Incl. War Excl. WRO"},
                    {4769,"W","COBRiskCodes:HighLevel:7:Generic:40:Description","VESSELS WAR AND OR CONFISCATION EXCL BREACH VOYAGES"},
                    {4770,"W3","COBRiskCodes:HighLevel:8:Generic:48:Description","UK EMPLOYERS LIABILITY"},
                    {4771,"W4","COBRiskCodes:HighLevel:8:Generic:48:Description","INTL WORKERS COMP AND EMPLOYERS LIAB EXCL USA AND UK"},
                    {4772,"W5","COBRiskCodes:HighLevel:4:Generic:15:Description","US WORKERS COMPENSATION PER PERSON EXPOSED"},
                    {4773,"W6","COBRiskCodes:HighLevel:4:Generic:15:Description","US WORKERS COMPENSATION CATASTROPHE EXPOSED"},
                    {4774,"WA","COBRiskCodes:HighLevel:9:Generic:54:Description","EXTENDED WARRANTY - From 01/01/05 also includes business previously coded \"WS\""},
                    {4775,"WB","COBRiskCodes:HighLevel:7:Generic:40:Description","VESSELS HULL WAR BREACH VOYAGES ONLY"},
                    {4776,"WL","COBRiskCodes:HighLevel:9:Generic:49:Description","WAR ON LAND - From 01/01/05 also includes business previously coded \"QL\""},
                    {4777,"WX","COBRiskCodes:HighLevel:7:Generic:40:Description","XOL VESSELS  WAR AND OR CONFISCATION RISKS ONLY - From 01/01/05 also includes business previously coded \"QX\""},
                    {4778,"X1","COBRiskCodes:HighLevel:2:Generic:12:Description","AVIATION EXCESS OF LOSS ON EXCESS OF LOSS - From 01/01/05 also includes business previously coded \"XZ\""},
                    {4779,"X2","COBRiskCodes:HighLevel:7:Generic:38:Description","MARINE XOL ON XOL INCL WAR"},
                    {4780,"X3","COBRiskCodes:HighLevel:11:Generic:62:Description","NM PROP OR PECUNIARY LOSS XOL ON XOL RETROCESSION"},
                    {4781,"XA","COBRiskCodes:HighLevel:11:Generic:63:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN USA"},
                    {4782,"XC","COBRiskCodes:HighLevel:11:Generic:64:Description","PER RISK EXCESS OF LOSS PROP PECUNIARY LOSS REINS"},
                    {4783,"XE","COBRiskCodes:HighLevel:7:Generic:38:Description","ENERGY ACCOUNT XOL INCL WAR - From 01/01/05 also includes business previously coded \"X5\""},
                    {4784,"XF","COBRiskCodes:HighLevel:4:Generic:16:Description","NM LIABILITY EXCESS OF LOSS IN USA - FROM 2019 RISK EXPOSED"},
                    {4785,"XG","COBRiskCodes:HighLevel:4:Generic:17:Description","NM LIABILITY EXCESS OF LOSS CLAIMS MADE OR LOSSES DISCOVERED EXCL USA "},
                    {4786,"XH","COBRiskCodes:HighLevel:4:Generic:17:Description","NM LIABILITY EXCESS OF LOSS LOSSES OCCURRING EXCL USA "},
                    {4787,"XJ","COBRiskCodes:HighLevel:11:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN JAPAN "},
                    {4788,"XM","COBRiskCodes:HighLevel:4:Generic:18:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUSINESS IN UK"},
                    {4789,"XN","COBRiskCodes:HighLevel:4:Generic:18:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUISNESS OUTSIDE UK"},
                    {4790,"XQ","COBRiskCodes:HighLevel:4:Generic:16:Description","NM LIABILITY EXCESS OF LOSS IN USA - CLASH"},
                    {4791,"XR","COBRiskCodes:HighLevel:11:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN REST OF WORLD "},
                    {4792,"XT","COBRiskCodes:HighLevel:7:Generic:38:Description","MARINE WHOLE ACCOUNT XOL INCL WAR"},
                    {4793,"XU","COBRiskCodes:HighLevel:11:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN ALL OF EUROPE INCL UK"},
                    {4794,"XY","COBRiskCodes:HighLevel:2:Generic:12:Description","AVIATION WHOLE ACCOUNT XOL INCL WAR EXCL XOL ON XOL - From 01/01/05 also includes business previously coded \"AR\" and \"AX\" - From 01/01/08 also includes business previously coded \"HX\""},
                    {4795,"1E","COBRiskCodes:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE PROPERTY"},
                    {4796,"1T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM ACCIDENT AND HEALTH"},
                    {4797,"2E","COBRiskCodes:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE LIABILITY"},
                    {4798,"2T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM AVIATION"},
                    {4799,"3E","COBRiskCodes:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE PROPERTY"},
                    {4800,"3T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM MARINE"},
                    {4801,"4E","COBRiskCodes:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE LIABILITY"},
                    {4802,"4T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM MISC AND PECUNIARY LOSS"},
                    {4803,"5T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM MOTOR"},
                    {4804,"6T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM PROPERTY"},
                    {4805,"7T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM THIRD PARTY LIABILITY"},
                    {4806,"8T","COBRiskCodes:Description","OVERSEAS LEG TERRORISM TRANSPORT"},
                    {4807,"AG","COBRiskCodes:Description","AGRICULTURAL CROP AND FORESTRY XOL TREATY INCL STOP LOSS"},
                    {4808,"AO","COBRiskCodes:Description","AVIATION PREMISES LEGAL LIABILITY NO PRODUCTS"},
                    {4809,"AP","COBRiskCodes:Description","AVIATION OR AEROSPACE PRODUCTS LEGAL LIABILITY"},
                    {4810,"AW","COBRiskCodes:Description","HULLS OF AIRCRAFT WAR OR CONFISCATION NO ACV"},
                    {4811,"B","COBRiskCodes:Description","Vessels TLO IV LOH and Containers Excl. WRO"},
                    {4812,"B2","COBRiskCodes:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY IN USA"},
                    {4813,"B3","COBRiskCodes:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY IN USA"},
                    {4814,"B4","COBRiskCodes:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY EXCL USA"},
                    {4815,"B5","COBRiskCodes:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY EXCL USA"},
                    {4816,"BB","COBRiskCodes:Description","FIDELITY COMPUTER CRIME AND BANKERS POLICIES"},
                    {4817,"BD","COBRiskCodes:Description","TERRORISM POOL RE"},
                    {4818,"CB","COBRiskCodes:Description","ENGINEERING ANNUAL RENEWABLE INCL CAR EAR MB CPE B&M EEI AND TREATY LOD"},
                    {4819,"CC","COBRiskCodes:Description","ENGINEERING SINGLE PROJECT NON RENEWABLE INCL CAR EAR AND TREATY RAD"},
                    {4820,"CF","COBRiskCodes:Description","CONTRACT FRUSTRATION FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {4821,"CR","COBRiskCodes:Description","CREDIT RISK FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {4822,"CT","COBRiskCodes:Description","ARMOURED CARRIERS AND CASH IN TRANSIT"},
                    {4823,"CY","COBRiskCodes:Description","Cyber Security Data and Privacy Breach"},
                    {4824,"CZ","COBRiskCodes:Description","CYBER SECURITY AND PROPERTY DAMAGE"},
                    {4825,"D2","COBRiskCodes:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS IN USA"},
                    {4826,"D3","COBRiskCodes:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS EXCL USA "},
                    {4827,"D4","COBRiskCodes:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS INCL USA"},
                    {4828,"D5","COBRiskCodes:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS EXCL USA"},
                    {4829,"D6","COBRiskCodes:Description","Employment Practices Liability Insurance (EPLI) Incl. US"},
                    {4830,"D7","COBRiskCodes:Description","Employment Practices Liability Insurance (EPLI) Excl. US"},
                    {4831,"D8","COBRiskCodes:Description","Transactional Liability insurance Incl. US"},
                    {4832,"D9","COBRiskCodes:Description","Transactional Liability insurance Excl. US"},
                    {4833,"DC","COBRiskCodes:Description","DIFFERENCE IN CONDITIONS"},
                    {4834,"E2","COBRiskCodes:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS INCL USA"},
                    {4835,"E3","COBRiskCodes:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS EXCL USA"},
                    {4836,"E4","COBRiskCodes:Description","PROF INDTY E&O FOR ACCOUNTANTS INCL USA"},
                    {4837,"E5","COBRiskCodes:Description","PROF INDTY E&O FOR ACCOUNTANTS EXCL USA"},
                    {4838,"E6","COBRiskCodes:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES INCL USA"},
                    {4839,"E7","COBRiskCodes:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES EXCL USA"},
                    {4840,"E8","COBRiskCodes:Description","MISC PROF IND E&O INCL USA EXCL \"E2\" \"E4\" \"E6\" CODES"},
                    {4841,"E9","COBRiskCodes:Description","MISC PROF IND E&O EXCL USA EXCL \"E3\" \"E5\" \"E7\" CODES"},
                    {4842,"EA","COBRiskCodes:Description","ENERGY LIABILITY ONSHORE CLAIMS MADE"},
                    {4843,"EB","COBRiskCodes:Description","ENERGY LIABILITY ONSHORE ALL OTHER"},
                    {4844,"EC","COBRiskCodes:Description","ENERGY CONSTRUCTION OFFSHORE PROP AND SEARCH PROD VSSLS EXCL WRO"},
                    {4845,"EF","COBRiskCodes:Description","ENERGY ONSHORE PROPERTY"},
                    {4846,"EG","COBRiskCodes:Description","ENERGY LIABILITY OFFSHORE CLAIMS MADE"},
                    {4847,"EH","COBRiskCodes:Description","ENERGY LIABILITY OFFSHORE ALL OTHER"},
                    {4848,"EM","COBRiskCodes:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {4849,"EN","COBRiskCodes:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP EXCL GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {4850,"EP","COBRiskCodes:Description","Environmental Impairment Liability or NM Pollution Liability"},
                    {4851,"EY","COBRiskCodes:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL GOM  WIND"},
                    {4852,"EZ","COBRiskCodes:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL EXCL GOM WIND"},
                    {4853,"F2","COBRiskCodes:Description","PROF INDTY E&O FOR FIN INSTITUTIONS INCL USA"},
                    {4854,"F3","COBRiskCodes:Description","PROF INDTY E&O FOR FIN INSTITUTIONS EXCL USA"},
                    {4855,"F4","COBRiskCodes:Description","Technology and Telecommunications E&O Incl. US"},
                    {4856,"F5","COBRiskCodes:Description","Technology and Telecommunications E&O Excl. US"},
                    {4857,"FA","COBRiskCodes:Description","FINE ART"},
                    {4858,"FG","COBRiskCodes:Description","FINANCIAL GUARANTEE (authorised syndicates only)"},
                    {4859,"FM","COBRiskCodes:Description","MORTGAGE INDEMNITY - From 01/01/05 also includes business previously coded \"BS\" "},
                    {4860,"G","COBRiskCodes:Description","MARINE LEGAL LIAB ALL OTHER NO CARGO EXCL WRO"},
                    {4861,"GC","COBRiskCodes:Description","MARINE LEGAL LIAB CLAIMS MADE NO CARGO EXCL WRO"},
                    {4862,"GH","COBRiskCodes:Description","HOSPITALS/ INSTITUTIONAL HEALTHCARE INSURANCE RISKS IN USA"},
                    {4863,"GM","COBRiskCodes:Description","MEDICAL MALPRACTICE EXCL USA "},
                    {4864,"GN","COBRiskCodes:Description","NURSING HOMES/ LONG-TERM AND ALLIED HEALTHCARE/OTHER MEDICAL MALPRACTICE RISKS IN USA"},
                    {4865,"GS","COBRiskCodes:Description","GENERAL SPECIE INCLUDING VAULT RISK"},
                    {4866,"GT","COBRiskCodes:Description","MEDICAL MALPRACTICE TREATY XOL IN USA"},
                    {4867,"GX","COBRiskCodes:Description","XOL MARINE LEGAL LIAB EXCL CARGO ALL OTHER EXCL WRO"},
                    {4868,"H2","COBRiskCodes:Description","AIRLINE HULL"},
                    {4869,"H3","COBRiskCodes:Description","GENERAL AVIATION HULL"},
                    {4870,"HA","COBRiskCodes:Description","AGRICULTURAL CROP AND FORESTRY EXCL XOL TREATY AND STOP LOSS"},
                    {4871,"HP","COBRiskCodes:Description","UK HOUSEHOLD BUSINESS"},
                    {4872,"JB","COBRiskCodes:Description","JEWELLERS BLOCK JEWELLERY ETC INCL ROBBERY - From 01/01/05 also includes business previously coded \"FR\" "},
                    {4873,"KA","COBRiskCodes:Description","PERSONAL ACCIDENT AND HEALTH CARVE OUT"},
                    {4874,"KB","COBRiskCodes:Description","DISABILITY LONG TERM BENEFIT"},
                    {4875,"KC","COBRiskCodes:Description","PERSONAL ACCIDENT AND HEALTH CREDITOR  DISABILITY"},
                    {4876,"KG","COBRiskCodes:Description","Personal Accident and Health Excl. K&R, KP KS AND KT CODES"},
                    {4877,"KM","COBRiskCodes:Description","MEDICAL EXPENSES INCL XS SPEC AND AGG SELF FUND"},
                    {4878,"KP","COBRiskCodes:Description","MARITIME EXTORTION EXCL KIDNAP AND RANSOM WRITTEN UNDER 'P'"},
                    {4879,"KS","COBRiskCodes:Description","PA AND HEALTH INCL SPORTS DIS OTHER THAN ACC DEATH"},
                    {4880,"KT","COBRiskCodes:Description","PA AND HEALTH FOR TRAVEL PACKAGE SCHEMES"},
                    {4881,"KX","COBRiskCodes:Description","PERSONAL ACCIDENT AND HEALTH CATASTROPHE XL - From 01/01/08 also includes business previously coded \"KL\""},
                    {4882,"L2","COBRiskCodes:Description","AIRLINE LIABILITY"},
                    {4883,"L3","COBRiskCodes:Description","GENERAL AVIATION LIABILITY"},
                    {4884,"LE","COBRiskCodes:Description","LEGAL EXPENSES    "},
                    {4885,"LJ","COBRiskCodes:Description","FOR USE BY LLOYDS JAPAN ONLY"},
                    {4886,"M2","COBRiskCodes:Description","UK MOTOR COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {4887,"M3","COBRiskCodes:Description","UK MOTOR COMP FOR FLEET AND COMMERCIAL VEHICLE"},
                    {4888,"M4","COBRiskCodes:Description","OTHER UK MOTOR COMP AND NON COMP EXCL \"M2\" AND \"M3\" CODES - From 01/01/08 includes business previously coded \"M7\""},
                    {4889,"M5","COBRiskCodes:Description","UK MOTOR NON COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {4890,"M6","COBRiskCodes:Description","UK MOTOR NON COMP FOR FLEET AND COMM VEHICLE"},
                    {4891,"MF","COBRiskCodes:Description","OVERSEAS MOTOR DAM AND TPL EXCL USA CAN EU AND EEA - From 01/01/05 also includes business previously coded \"MD\" and \"ME\""},
                    {4892,"MG","COBRiskCodes:Description","USA AND CANADA MOTOR VEHICLE PHYSICAL DAMAGE"},
                    {4893,"MH","COBRiskCodes:Description","USA AND CANADA MOTOR VEHICLE THIRD PARTY LIABILITY"},
                    {4894,"MI","COBRiskCodes:Description","USA AND CANADA MOTOR DAMAGE AND 3RD PARTY LIAB"},
                    {4895,"MP","COBRiskCodes:Description","EU AND EEA MOTOR PD AND TPL EXCL UK - From 01/01/05 also includes business previously coded \"MM\" and \"MN\""},
                    {4896,"N","COBRiskCodes:Description","LIVESTOCK"},
                    {4897,"NA","COBRiskCodes:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA - FROM 2019 EXCL BINDERS "},
                    {4898,"NB","COBRiskCodes:Description","BLOODSTOCK"},
                    {4899,"NC","COBRiskCodes:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA - FROM 2019 EXCL BINDERS"},
                    {4900,"NL","COBRiskCodes:Description","NUCLEAR LIABILITY FROM 2019 LIMITATION NOT GREATER THAN 10 YEARS"},
                    {4901,"NP","COBRiskCodes:Description","NUCLEAR PROPERTY DAMAGE"},
                    {4902,"NR","COBRiskCodes:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA -  BINDERS ONLY"},
                    {4903,"NS","COBRiskCodes:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA -  BINDERS ONLY"},
                    {4904,"NV","COBRiskCodes:Description","NUCLEAR LIABILITY LIMITATION EXCESS OF 10 YEARS"},
                    {4905,"NX","COBRiskCodes:Description","LIVESTOCK EXCESS OF LOSS"},
                    {4906,"O","COBRiskCodes:Description","YACHTS INCL WAR EXCL WRO"},
                    {4907,"P","COBRiskCodes:Description","MISCELLANEOUS PECUNIARY LOSS - From 01/01/05 also includes business previously coded \"PE\" \"PP\" \"PS\" and \"PW\""},
                    {4908,"P2","COBRiskCodes:Description","PHYS DAMAGE FOR PRIM LAYER PPTY IN USA EXCL BINDERS"},
                    {4909,"P3","COBRiskCodes:Description","PHYS DAMAGE FOR PRIM LAYER PPTY EXCL USA EXCL BINDERS"},
                    {4910,"P4","COBRiskCodes:Description","PHYS DAMAGE FOR FULL VALUE PPTY IN USA EXCL BINDERS"},
                    {4911,"P5","COBRiskCodes:Description","PHYS DAMAGE FOR FULL VALUE PPTY EXCL USA EXCL BINDERS"},
                    {4912,"P6","COBRiskCodes:Description","PHYS DAMAGE FOR XS LAYER PPTY IN USA EXCL BINDERS"},
                    {4913,"P7","COBRiskCodes:Description","PHYS DAMAGE FOR XS LAYER PPTY EXCL USA EXCL BINDERS"},
                    {4914,"PB","COBRiskCodes:Description","PRODUCT RECALL"},
                    {4915,"PC","COBRiskCodes:Description","CANCELLATION AND ABANDONMENT"},
                    {4916,"PF","COBRiskCodes:Description","FILM INCLUDING FILM COMPLETION BONDS  "},
                    {4917,"PG","COBRiskCodes:Description","OPERATIONAL POWER GENERATION TRANSMISSION AND UTILITIES EXCL CONSTRUCTION "},
                    {4918,"PN","COBRiskCodes:Description","NON APPEARANCE"},
                    {4919,"PQ","COBRiskCodes:Description","ROADSIDE RESCUE     "},
                    {4920,"PR","COBRiskCodes:Description","POLITICAL RISK EXCL CONFISCATION VESSELS AIRCRAFT"},
                    {4921,"PU","COBRiskCodes:Description","MISCELLANEOUS CONTINGENCY - From 01/01/05 also includes business previously coded \"PO\""},
                    {4922,"PZ","COBRiskCodes:Description","PRIZE INDEMNITY INCLUDING HOLE IN ONE"},
                    {4923,"Q","COBRiskCodes:Description","CARGO WAR AND OR CONFISCATION RISKS ONLY"},
                    {4924,"RX","COBRiskCodes:Description","XOL HULLS OF AIRCRAFT WAR AND OR CONFIS RISKS ONLY "},
                    {4925,"SA","COBRiskCodes:Description","SEAFARERS ABANDONMENT (authorised syndicates only)"},
                    {4926,"SB","COBRiskCodes:Description","SURETY BOND REINSURANCE - From 01/01/05 also includes business previously coded \"FC\" or \"FS\" "},
                    {4927,"SC","COBRiskCodes:Description","SPACE RISKS LAUNCH COMMISSIONING PERIOD AND TRANSPOND OP - From 01/01/08 also includes business previously coded \"CX\""},
                    {4928,"SL","COBRiskCodes:Description","SPACE RISK LIABILITY NO PRODUCTS LEGAL LIABILITY"},
                    {4929,"SO","COBRiskCodes:Description","SPACE RISKS TRANSPONDER OPERATING"},
                    {4930,"SR","COBRiskCodes:Description","AGG STOP LOSS AND XOL MARINE OUTWARD WHOLE ACCOUNT"},
                    {4931,"T","COBRiskCodes:Description","Vessels Excl. TLO IV LOH Containers Shipbuilding and WRO"},
                    {4932,"TC","COBRiskCodes:Description","COMMERCIAL RITC"},
                    {4933,"TL","COBRiskCodes:Description","TEMPORARY LIFE AND PERMANENT HEALTH"},
                    {4934,"TO","COBRiskCodes:Description","OVERSEAS STAND ALONE TERROR EXCL \"1T\" to \"8T\" & \"1E\" to \"4E\""},
                    {4935,"TR","COBRiskCodes:Description","ALL RISK PHYSICAL OR LOSS DAMAGE  DIRECT PPNL RI"},
                    {4936,"TS","COBRiskCodes:Description","SHIPBUILDING EXCL ENERGY CONSTRUCTION"},
                    {4937,"TT","COBRiskCodes:Description","TITLE INSURANCE"},
                    {4938,"TU","COBRiskCodes:Description","UK STAND ALONE TERRORISM WHICH IS NON POOL RE"},
                    {4939,"TW","COBRiskCodes:Description","TERRORISM AND WAR ON LAND WHOLE ACCOUNT XOL TREATY RI INCL RI OF POOLS "},
                    {4940,"TX","COBRiskCodes:Description","XOL VESSELS SHIPBLDG ACV LOH INCL WAR EXCL WRO - From 01/01/05 also includes business previously coded \"OX\""},
                    {4941,"UA","COBRiskCodes:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - FROM 2019 EXCL BINDERS"},
                    {4942,"UC","COBRiskCodes:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA - FROM 2019 EXCL BINDERS"},
                    {4943,"UR","COBRiskCodes:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - BINDERS ONLY"},
                    {4944,"US","COBRiskCodes:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA -  BINDERS ONLY"},
                    {4945,"V","COBRiskCodes:Description","CARGO ALL RISKS INCL WAR EXCL WRO"},
                    {4946,"VL","COBRiskCodes:Description","LEGAL LIAB CARGO AND PROP INCL CCC OF ASSURED EXCL WRO"},
                    {4947,"VX","COBRiskCodes:Description","XOL Cargo Incl. War Excl. WRO"},
                    {4948,"W","COBRiskCodes:Description","VESSELS WAR AND OR CONFISCATION EXCL BREACH VOYAGES"},
                    {4949,"W3","COBRiskCodes:Description","UK EMPLOYERS LIABILITY"},
                    {4950,"W4","COBRiskCodes:Description","INTL WORKERS COMP AND EMPLOYERS LIAB EXCL USA AND UK"},
                    {4951,"W5","COBRiskCodes:Description","US WORKERS COMPENSATION PER PERSON EXPOSED"},
                    {4952,"W6","COBRiskCodes:Description","US WORKERS COMPENSATION CATASTROPHE EXPOSED"},
                    {4953,"WA","COBRiskCodes:Description","EXTENDED WARRANTY - From 01/01/05 also includes business previously coded \"WS\""},
                    {4954,"WB","COBRiskCodes:Description","VESSELS HULL WAR BREACH VOYAGES ONLY"},
                    {4955,"WL","COBRiskCodes:Description","WAR ON LAND - From 01/01/05 also includes business previously coded \"QL\""},
                    {4956,"WX","COBRiskCodes:Description","XOL VESSELS  WAR AND OR CONFISCATION RISKS ONLY - From 01/01/05 also includes business previously coded \"QX\""},
                    {4957,"X1","COBRiskCodes:Description","AVIATION EXCESS OF LOSS ON EXCESS OF LOSS - From 01/01/05 also includes business previously coded \"XZ\""},
                    {4958,"X2","COBRiskCodes:Description","MARINE XOL ON XOL INCL WAR"},
                    {4959,"X3","COBRiskCodes:Description","NM PROP OR PECUNIARY LOSS XOL ON XOL RETROCESSION"},
                    {4960,"XA","COBRiskCodes:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN USA"},
                    {4961,"XC","COBRiskCodes:Description","PER RISK EXCESS OF LOSS PROP PECUNIARY LOSS REINS"},
                    {4962,"XE","COBRiskCodes:Description","ENERGY ACCOUNT XOL INCL WAR - From 01/01/05 also includes business previously coded \"X5\""},
                    {4963,"XF","COBRiskCodes:Description","NM LIABILITY EXCESS OF LOSS IN USA - FROM 2019 RISK EXPOSED"},
                    {4964,"XG","COBRiskCodes:Description","NM LIABILITY EXCESS OF LOSS CLAIMS MADE OR LOSSES DISCOVERED EXCL USA "},
                    {4965,"XH","COBRiskCodes:Description","NM LIABILITY EXCESS OF LOSS LOSSES OCCURRING EXCL USA "},
                    {4966,"XJ","COBRiskCodes:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN JAPAN "},
                    {4967,"XM","COBRiskCodes:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUSINESS IN UK"},
                    {4968,"XN","COBRiskCodes:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUISNESS OUTSIDE UK"},
                    {4969,"XQ","COBRiskCodes:Description","NM LIABILITY EXCESS OF LOSS IN USA - CLASH"},
                    {4970,"XR","COBRiskCodes:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN REST OF WORLD "},
                    {4971,"XT","COBRiskCodes:Description","MARINE WHOLE ACCOUNT XOL INCL WAR"},
                    {4972,"XU","COBRiskCodes:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN ALL OF EUROPE INCL UK"},
                    {4973,"XY","COBRiskCodes:Description","AVIATION WHOLE ACCOUNT XOL INCL WAR EXCL XOL ON XOL - From 01/01/05 also includes business previously coded \"AR\" and \"AX\" - From 01/01/08 also includes business previously coded \"HX\""},
                    {4974,"1E","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - offshore energy - property"},
                    {4975,"1T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - accident and health"},
                    {4976,"2E","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - offshore energy - liability"},
                    {4977,"2T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - aviation"},
                    {4978,"3E","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - onshore energy - property"},
                    {4979,"3T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - marine"},
                    {4980,"4E","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - onshore energy - liability"},
                    {4981,"4T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - pecuniary loss and other miscellaneous classes"},
                    {4982,"5T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - motor"},
                    {4983,"6T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - property"},
                    {4984,"7T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - third party liability"},
                    {4985,"8T","COBRiskCodes:DescriptionExpanded","Terrorism subject to overseas legislation - transport"},
                    {4986,"AG","COBRiskCodes:DescriptionExpanded","Agriculture crop and forestry excess of loss treaty including stop loss "},
                    {4987,"AO","COBRiskCodes:DescriptionExpanded","Aviation premises and other airport legal liabiliities excluding products liability"},
                    {4988,"AP","COBRiskCodes:DescriptionExpanded","Aviation and aerospace products manufacturers' liability "},
                    {4989,"AW","COBRiskCodes:DescriptionExpanded","Aircraft hull war and confiscation excluding air cushioned vehicles"},
                    {4990,"B","COBRiskCodes:DescriptionExpanded","Total loss only in respect of vessels, shipbuilding, air cushioned vehicles, loss of hire and containers excluding war risks only"},
                    {4991,"B2","COBRiskCodes:DescriptionExpanded","Physical damage binders for private property in USA"},
                    {4992,"B3","COBRiskCodes:DescriptionExpanded","Physical damage binders for commercial property in USA"},
                    {4993,"B4","COBRiskCodes:DescriptionExpanded","Physical damage binders for private property worldwide excluding USA"},
                    {4994,"B5","COBRiskCodes:DescriptionExpanded","Physical damage binders for commercial property worldwide excluding USA"},
                    {4995,"BB","COBRiskCodes:DescriptionExpanded","Fidelity, bankers and computer crime"},
                    {4996,"BD","COBRiskCodes:DescriptionExpanded","Terrorism coverage ceded to Pool Re"},
                    {4997,"CB","COBRiskCodes:DescriptionExpanded","Engineering annual - including contractors all risk, erection all risk, machinery breakdown, contractors plant and equipment, boilers and machinery, electronic equipment and treaty losses occurring"},
                    {4998,"CC","COBRiskCodes:DescriptionExpanded","Engineering single long-term - including contractors all risk, erection all risk and treaty risks attaching"},
                    {4999,"CF","COBRiskCodes:DescriptionExpanded","Contract frustration (contracts with soverign buyers)"},
                    {5000,"CR","COBRiskCodes:DescriptionExpanded","Credit risk (contracts with private sector buyers)"},
                    {5001,"CT","COBRiskCodes:DescriptionExpanded","Armoured carriers and cash in transit"},
                    {5002,"CY","COBRiskCodes:DescriptionExpanded","Coverage in respect of first or third party costs, expenses or damages due to a breach (or threatened breach) of cyber security and/or privacy of data, that does not include damage to physical property"},
                    {5003,"CZ","COBRiskCodes:DescriptionExpanded","Coverage in respect of first or third party costs, expenses or damages due to a breach of cyber security that includes damage to physical property"},
                    {5004,"D2","COBRiskCodes:DescriptionExpanded","Directors and officers liability in USA excluding financial institutions"},
                    {5005,"D3","COBRiskCodes:DescriptionExpanded","Directors and officers liability worldwide excluding USA and excluding financial institutions"},
                    {5006,"D4","COBRiskCodes:DescriptionExpanded","Directors and officers liability for financial instituitons including USA"},
                    {5007,"D5","COBRiskCodes:DescriptionExpanded","Directors and officers liability for financial instituitons worldwide excluding USA"},
                    {5008,"D6","COBRiskCodes:DescriptionExpanded","This provides cover for wrongful acts and violations arising from employment related harassment and discrimination including USA"},
                    {5009,"D7","COBRiskCodes:DescriptionExpanded","This provides cover for wrongful acts and violations arising from employment related harassment and discrimination excluding USA"},
                    {5010,"D8","COBRiskCodes:DescriptionExpanded","This provides cover to reduce or extinguish the impact of potential liabilities which may arise in connection with a business merger, acquisition or restructure. The coverage caters for breaches of representations, warranties or indemnities in the transaction agreement, any potential tax liabilities that may arise and other contingent liability claims including USA"},
                    {5011,"D9","COBRiskCodes:DescriptionExpanded","This provides cover to reduce or extinguish the impact of potential liabilities which may arise in connection with a business merger, acquisition or restructure. The coverage caters for breaches of representations, warranties or indemnities in the transaction agreement, any potential tax liabilities that may arise and other contingent liability claims Excluding USA"},
                    {5012,"DC","COBRiskCodes:DescriptionExpanded","Difference in conditions - all natural catastrophe perils excluding fire"},
                    {5013,"E2","COBRiskCodes:DescriptionExpanded","Professional indemnity for legal profession including USA"},
                    {5014,"E3","COBRiskCodes:DescriptionExpanded","Professional indemnity for legal profession excluding USA"},
                    {5015,"E4","COBRiskCodes:DescriptionExpanded","Professional indemnity for accountants including USA"},
                    {5016,"E5","COBRiskCodes:DescriptionExpanded","Professional indemnity for accountants excluding USA"},
                    {5017,"E6","COBRiskCodes:DescriptionExpanded","Professional indemnity for all construction related industries eg.architects & engineers, design & construct, and single projects including USA"},
                    {5018,"E7","COBRiskCodes:DescriptionExpanded","Professional indemnity for all construction related industries eg.architects & engineers, design & construct, and single projects excluding USA"},
                    {5019,"E8","COBRiskCodes:DescriptionExpanded","Miscellaneous professional indemnity including USA and excluding business under risk codes E2, E4 and E6"},
                    {5020,"E9","COBRiskCodes:DescriptionExpanded","Miscellaneous professional indemnity excluding USA and excluding business under risk codes E3, E5 and E7"},
                    {5021,"EA","COBRiskCodes:DescriptionExpanded","On-shore energy liability on a claims made basis"},
                    {5022,"EB","COBRiskCodes:DescriptionExpanded","On-shore energy liability on any basis other than claims made"},
                    {5023,"EC","COBRiskCodes:DescriptionExpanded","Off-shore energy construction of search and production vessels in respect of property damage perils excluding war risks only"},
                    {5024,"EF","COBRiskCodes:DescriptionExpanded","On-shore energy property"},
                    {5025,"EG","COBRiskCodes:DescriptionExpanded","Off-shore energy liability on a claims made basis"},
                    {5026,"EH","COBRiskCodes:DescriptionExpanded","Off-shore energy liability on any basis other than claims made"},
                    {5027,"EM","COBRiskCodes:DescriptionExpanded","Off-shore energy search and production vessels in respect of property damage perils exposed to wind in Gulf of Mexico excluding war risks only and construction"},
                    {5028,"EN","COBRiskCodes:DescriptionExpanded","Off-shore energy search and production vessels in respect of property damage perils excluding wind eposure in Gulf of Mexico excluding war risks only and construction"},
                    {5029,"EP ","COBRiskCodes:DescriptionExpanded","This provides cover for first party clean-up costs and/or third party liabilities (including associated legal defence costs) resulting from sudden or gradual pollution or environmental damage. Policies written on both a claims made or other trigger (e.g. occurrence) and in any territory should be written in this risk code."},
                    {5030,"EY","COBRiskCodes:DescriptionExpanded","Energy operators extra expense and control of well in respect of wind exposure in Gulf of Mexico"},
                    {5031,"EZ","COBRiskCodes:DescriptionExpanded","Energy operators extra expense and control of well excluding wind exposure in Gulf of Mexico"},
                    {5032,"F2","COBRiskCodes:DescriptionExpanded","Professional indemnity for financial institutions including USA"},
                    {5033,"F3","COBRiskCodes:DescriptionExpanded","Professional indemnity for financial institutions excluding USA"},
                    {5034,"F4","COBRiskCodes:DescriptionExpanded","This provides cover for Technology and Telecommunications Providers E&O, excluding coverage allocated to CY or CZ  including USA risks."},
                    {5035,"F5","COBRiskCodes:DescriptionExpanded","This provides cover for Technology and Telecommunications Providers E&O, excluding coverage allocated to CY or CZ excluding USA risks."},
                    {5036,"FA","COBRiskCodes:DescriptionExpanded","Fine art"},
                    {5037,"FG","COBRiskCodes:DescriptionExpanded","Financial guarantee other than excepted classes"},
                    {5038,"FM","COBRiskCodes:DescriptionExpanded","Mortgage indemnity (Nb: this covers the expenses of mortgage lenders incurred in foreclosure of property and does not include the US class of Mortgage Impairment)"},
                    {5039,"G","COBRiskCodes:DescriptionExpanded","Marine liability on any basis other than claims made excluding cargo, energy and war risks only"},
                    {5040,"GC","COBRiskCodes:DescriptionExpanded","Marine liability on a claims made basis excluding cargo, energy and war risks only"},
                    {5041,"GH","COBRiskCodes:DescriptionExpanded","Medical malpractice liability in respect of hospitals and similar major institutional healthcare other than nursing homes and allied healthcare risks in the USA"},
                    {5042,"GM","COBRiskCodes:DescriptionExpanded","Medical malpractice liability excluding USA"},
                    {5043,"GN","COBRiskCodes:DescriptionExpanded","Medical malpractice liability in respect of nursing homes and allied healthcare other than hospitals and similar major institutional healthcare risks in the USA"},
                    {5044,"GS","COBRiskCodes:DescriptionExpanded","General specie including vault risk"},
                    {5045,"GT","COBRiskCodes:DescriptionExpanded","Medical malpractice liability excess of loss treaty in the USA"},
                    {5046,"GX","COBRiskCodes:DescriptionExpanded","Excess of loss marine liability on any basis other than claims made basis excluding cargo, energy and war risks only"},
                    {5047,"H2","COBRiskCodes:DescriptionExpanded","Airline hull"},
                    {5048,"H3","COBRiskCodes:DescriptionExpanded","General aviation hull"},
                    {5049,"HA","COBRiskCodes:DescriptionExpanded","Agriculture crop and forestry excluding excess of loss treaty and stop loss"},
                    {5050,"HP","COBRiskCodes:DescriptionExpanded","Household insurance business in the UK"},
                    {5051,"JB","COBRiskCodes:DescriptionExpanded","Jewellers' block and general jewellery including robbery"},
                    {5052,"KA","COBRiskCodes:DescriptionExpanded","Personal accident and health carve-out from workers compensation"},
                    {5053,"KB","COBRiskCodes:DescriptionExpanded","Disability insurance with benefits payable in regular instalments for periods greater than 60 months."},
                    {5054,"KC","COBRiskCodes:DescriptionExpanded","Personal accident and health creditor disability"},
                    {5055,"KG","COBRiskCodes:DescriptionExpanded","General personal accident and health excluding Kidnap and Ransom risk and all other coverage falling under other \"K\" codes"},
                    {5056,"KM","COBRiskCodes:DescriptionExpanded","Medical expenses including protection of self-insured employer medical plans"},
                    {5057,"KP","COBRiskCodes:DescriptionExpanded","ReimbursementÂ ofÂ costs associated with securing the release of marine hull or cargo or crew following the illegal seizure of a vessel by persons meeting the description of pirates"},
                    {5058,"KS","COBRiskCodes:DescriptionExpanded","Personal accident and health in respect of sports disability other than accidental death only"},
                    {5059,"KT","COBRiskCodes:DescriptionExpanded","Personal accident and health in respect of travel"},
                    {5060,"KX","COBRiskCodes:DescriptionExpanded","Whole account excess of loss treaty in respect of personal accident and health"},
                    {5061,"L2","COBRiskCodes:DescriptionExpanded","Airline liability"},
                    {5062,"L3","COBRiskCodes:DescriptionExpanded","General aviation liability"},
                    {5063,"LE","COBRiskCodes:DescriptionExpanded","Legal expenses"},
                    {5064,"LJ","COBRiskCodes:DescriptionExpanded","For use by Lloyd's Japan only"},
                    {5065,"M2","COBRiskCodes:DescriptionExpanded","Motor comprehensive for cars and motorcycles in the UK"},
                    {5066,"M3","COBRiskCodes:DescriptionExpanded","Motor comprehensive for fleets and commercial vehicles in the UK"},
                    {5067,"M4","COBRiskCodes:DescriptionExpanded","Motor comprehensive and non comprehensive in the UK other than those falling under risk codes M2 and M3"},
                    {5068,"M5","COBRiskCodes:DescriptionExpanded","Motor other than comprehensive for private cars and motorcycles in the UK"},
                    {5069,"M6","COBRiskCodes:DescriptionExpanded","Motor other than comprehensive for fleets and commercial vehicles in the UK"},
                    {5070,"MF","COBRiskCodes:DescriptionExpanded","Overseas motor damage and third party liability excluding the USA, Canada the European Union and the European Economic Area"},
                    {5071,"MG","COBRiskCodes:DescriptionExpanded","Motor vehicle physical damage in the USA and Canada"},
                    {5072,"MH","COBRiskCodes:DescriptionExpanded","Motor vehicle third party liability in the USA and Canada"},
                    {5073,"MI","COBRiskCodes:DescriptionExpanded","Motor vehicle physical damage and third party liability in the USA and Canada"},
                    {5074,"MP","COBRiskCodes:DescriptionExpanded","Motor vehicle physical damage and third party liability in the European Union and the European Economic Area"},
                    {5075,"N","COBRiskCodes:DescriptionExpanded","Livestock other than bloodstock"},
                    {5076,"NA","COBRiskCodes:DescriptionExpanded","General and miscellaneous non-marine liability on any basis other than claims made excluding the USA - excluding binders"},
                    {5077,"NB","COBRiskCodes:DescriptionExpanded","Bloodstock"},
                    {5078,"NC","COBRiskCodes:DescriptionExpanded","General and miscellaneous non-marine liability on a claims made basis excluding the USA - excluding binders"},
                    {5079,"NL","COBRiskCodes:DescriptionExpanded","Nuclear liability where the limitation period for injury claims is not greater than 10 years."},
                    {5080,"NP","COBRiskCodes:DescriptionExpanded","Nuclear property damage"},
                    {5081,"NR","COBRiskCodes:DescriptionExpanded","General and miscellaneous non-marine liability on any basis other than claims made excluding the USA -  binders only"},
                    {5082,"NS","COBRiskCodes:DescriptionExpanded","General and miscellaneous non-marine liability on a claims made basis excluding the USA - binders only"},
                    {5083,"NV","COBRiskCodes:DescriptionExpanded","Nuclear liability where the limitation period for injury claims is greater than 10 years."},
                    {5084,"NX","COBRiskCodes:DescriptionExpanded","Livestock and bloodstock excess of loss treaty"},
                    {5085,"O","COBRiskCodes:DescriptionExpanded","Yachts including war but excluding war risks only (stand alone)"},
                    {5086,"P","COBRiskCodes:DescriptionExpanded","Miscellaneous pecuniary loss"},
                    {5087,"P2","COBRiskCodes:DescriptionExpanded","Physical damage in respect of primary layer property business in the USA excluding binder business"},
                    {5088,"P3","COBRiskCodes:DescriptionExpanded","Physical damage in respect of primary layer property business other than in the USA excluding binder business"},
                    {5089,"P4","COBRiskCodes:DescriptionExpanded","Physical damage in respect of full value property business in the USA excluding binder business"},
                    {5090,"P5","COBRiskCodes:DescriptionExpanded","Physical damage in respect of full value property business other than in the USA excluding binder business"},
                    {5091,"P6","COBRiskCodes:DescriptionExpanded","Physical damage in respect of excess layer property business in the USA excluding binder business"},
                    {5092,"P7","COBRiskCodes:DescriptionExpanded","Physical damage in respect of excess layer property business other than in the USA excluding binder business"},
                    {5093,"PB","COBRiskCodes:DescriptionExpanded","Product recall"},
                    {5094,"PC","COBRiskCodes:DescriptionExpanded","Cancellation and abandonment of events"},
                    {5095,"PF","COBRiskCodes:DescriptionExpanded","Film coverage including film completion bonds"},
                    {5096,"PG","COBRiskCodes:DescriptionExpanded","Operational power generation and transmission and other utilities excluding construction risks"},
                    {5097,"PN","COBRiskCodes:DescriptionExpanded","Non-appearance of performers, sports people and the like"},
                    {5098,"PQ","COBRiskCodes:DescriptionExpanded","Roadside assistrance and rescue"},
                    {5099,"PR","COBRiskCodes:DescriptionExpanded","Political risks other than those risks classifed as CF and CR and excluding confiscation of ships and aircraft"},
                    {5100,"PU","COBRiskCodes:DescriptionExpanded","Miscellaneous contingency"},
                    {5101,"PZ","COBRiskCodes:DescriptionExpanded","Prize indemnity including hole in one cover"},
                    {5102,"Q","COBRiskCodes:DescriptionExpanded","Cargo war and/or confiscation risks only"},
                    {5103,"RX","COBRiskCodes:DescriptionExpanded","Excess of loss treaty in respect of aircraft hull war and confiscation risks only"},
                    {5104,"SA","COBRiskCodes:DescriptionExpanded","SEAFARERS ABANDONMENT"},
                    {5105,"SB","COBRiskCodes:DescriptionExpanded","Surety bond reinsurance"},
                    {5106,"SC","COBRiskCodes:DescriptionExpanded","Launch, commissioning and transponder operating in respect of space risks"},
                    {5107,"SL","COBRiskCodes:DescriptionExpanded","Space risks liability excluding products liability"},
                    {5108,"SO","COBRiskCodes:DescriptionExpanded","Space risks transponder operating"},
                    {5109,"SR","COBRiskCodes:DescriptionExpanded","Marine whole account excess loss treaty and stop loss (applicable to outward reinsurance only)"},
                    {5110,"T","COBRiskCodes:DescriptionExpanded","Vessels excluding shipbuilding, air cushioned vehicles, loss of hire and containers - excluding war risks only"},
                    {5111,"TC","COBRiskCodes:DescriptionExpanded","Commercial reinsurance to close"},
                    {5112,"TL","COBRiskCodes:DescriptionExpanded","Term life and permanent health"},
                    {5113,"TO","COBRiskCodes:DescriptionExpanded","Overseas stand alone terrorism physical damage excluding business falling under risk codes 1T to 8T and 1E to 4E"},
                    {5114,"TR","COBRiskCodes:DescriptionExpanded","Property damage pro rata treaty"},
                    {5115,"TS","COBRiskCodes:DescriptionExpanded","Shipbuilding excluding energy construction"},
                    {5116,"TT","COBRiskCodes:DescriptionExpanded","Indemnity Insurance which insures against financial loss from defects to titles on Property and the invalidity of loans held on those properties. This will cover legal defence costs and/or monetary loss amounts incurred"},
                    {5117,"TU","COBRiskCodes:DescriptionExpanded","UK stand alone terrorism physical damage that is not covered by Pool Re."},
                    {5118,"TW","COBRiskCodes:DescriptionExpanded","Excess of loss treaty reinsurance in respect of terrorism, war, civil war and related perils including reinsurance of national pools providing such cover"},
                    {5119,"TX","COBRiskCodes:DescriptionExpanded","Excess of loss treaty in respect of vessels, shipbuilding, air cushioned vehicles, loss of hire including war but excluding war risks only"},
                    {5120,"UA","COBRiskCodes:DescriptionExpanded","General and miscellaneous non marine liability on any basis other than claims made including the USA - excluding binders"},
                    {5121,"UC","COBRiskCodes:DescriptionExpanded","General and miscellaneous liability on a claims made basis including the USA - excluding binders"},
                    {5122,"UR","COBRiskCodes:DescriptionExpanded","General and miscellaneous non marine liability on any basis other than claims made including the USA - binders only"},
                    {5123,"US","COBRiskCodes:DescriptionExpanded","General and miscellaneous liability on a claims made basis including the USA - binders only"},
                    {5124,"V","COBRiskCodes:DescriptionExpanded","Cargo all risks including war but excluding war risks only (stand alone)"},
                    {5125,"VL","COBRiskCodes:DescriptionExpanded","Legal liability in respect of cargo and property of the insured including care custody control excluding war risks only (stand alone)"},
                    {5126,"VX","COBRiskCodes:DescriptionExpanded","Excess of loss treaty in respect of cargo all risks including war but excluding war risks only (stand alone)"},
                    {5127,"W","COBRiskCodes:DescriptionExpanded","War and/or confiscation in respect of vessels excluding breach voyages"},
                    {5128,"W3","COBRiskCodes:DescriptionExpanded","UK employers liability"},
                    {5129,"W4","COBRiskCodes:DescriptionExpanded","Overseas workers compensation and employers liability excluding the USA and the UK"},
                    {5130,"W5","COBRiskCodes:DescriptionExpanded","US workers compensation with per person exposure"},
                    {5131,"W6","COBRiskCodes:DescriptionExpanded","US workers compensation catastrophe (excess of per person exposure)"},
                    {5132,"WA","COBRiskCodes:DescriptionExpanded","Extended warranty"},
                    {5133,"WB","COBRiskCodes:DescriptionExpanded","War and confiscation of vessels in respect of breach voyages only"},
                    {5134,"WL","COBRiskCodes:DescriptionExpanded","Property physical damage for war on land"},
                    {5135,"WX","COBRiskCodes:DescriptionExpanded","Excess loss treaty in respect of war and/or confiscation of vessels"},
                    {5136,"X1","COBRiskCodes:DescriptionExpanded","Aviation excess of loss treaty on excess of loss"},
                    {5137,"X2","COBRiskCodes:DescriptionExpanded","Marine excess of loss treaty on excess of loss, including war"},
                    {5138,"X3","COBRiskCodes:DescriptionExpanded","Non-marine property including business interruption excess of loss treaty on excess of loss"},
                    {5139,"XA","COBRiskCodes:DescriptionExpanded","Non-marine property damage including business interruption whole account excess of loss treaty in the USA"},
                    {5140,"XC","COBRiskCodes:DescriptionExpanded","Property damage including business interruption per risk excess of loss treaty"},
                    {5141,"XE","COBRiskCodes:DescriptionExpanded","Energy whole account excess of loss treaty including war"},
                    {5142,"XF","COBRiskCodes:DescriptionExpanded","Non-marine liability whole account excess of loss treaty in the USA which is risk exposed."},
                    {5143,"XG","COBRiskCodes:DescriptionExpanded","Non-marine liability whole account excess of loss treaty where the original business is written on a claims made and/or losses discovered basis excluding the USA"},
                    {5144,"XH","COBRiskCodes:DescriptionExpanded","Non-marine liability whole account excess of loss treaty where the original business is written on an occurrence basis excluding the USA"},
                    {5145,"XJ","COBRiskCodes:DescriptionExpanded","Non-marine property damage including business interruption whole account excess of loss treaty in Japan"},
                    {5146,"XM","COBRiskCodes:DescriptionExpanded","Motor whole account excess of loss treaty where original business is in the UK only"},
                    {5147,"XN","COBRiskCodes:DescriptionExpanded","Motor whole account excess of loss treaty where original business is outside the UK"},
                    {5148,"XQ","COBRiskCodes:DescriptionExpanded","Non-marine liability whole account excess of loss treaty in the USA clash cover"},
                    {5149,"XR","COBRiskCodes:DescriptionExpanded","Non-marine property damage including business interruption whole account excess of loss treaty worldwide other than Europe, Japan and the USA"},
                    {5150,"XT","COBRiskCodes:DescriptionExpanded","Marine whole account excess of loss treaty including war"},
                    {5151,"XU","COBRiskCodes:DescriptionExpanded","Non-marine property damage including business interruption whole account excess of loss treaty in Europe including the UK"},
                    {5152,"XY","COBRiskCodes:DescriptionExpanded","Aviation whole account excess of loss treaty including war"},
                    {5153,"1E","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5154,"1T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5155,"2E","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5156,"2T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5157,"3E","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5158,"3T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5159,"4E","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5160,"4T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5161,"5T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5162,"6T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5163,"7T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5164,"8T","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5165,"AG","COBRiskCodes:FirstYearOfAccount","1993"},
                    {5166,"AO","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5167,"AP","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5168,"AW","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5169,"B","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5170,"B2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5171,"B3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5172,"B4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5173,"B5","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5174,"BB","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5175,"BD","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5176,"CB","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5177,"CC","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5178,"CF","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5179,"CR","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5180,"CT","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5181,"CY","COBRiskCodes:FirstYearOfAccount","2013"},
                    {5182,"CZ","COBRiskCodes:FirstYearOfAccount","2015"},
                    {5183,"D2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5184,"D3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5185,"D4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5186,"D5","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5187,"D6","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5188,"D7","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5189,"D8","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5190,"D9","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5191,"DC","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5192,"E2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5193,"E3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5194,"E4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5195,"E5","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5196,"E6","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5197,"E7","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5198,"E8","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5199,"E9","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5200,"EA","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5201,"EB","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5202,"EC","COBRiskCodes:FirstYearOfAccount","2010"},
                    {5203,"EF","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5204,"EG","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5205,"EH","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5206,"EM","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5207,"EN","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5208,"EP","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5209,"EY","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5210,"EZ","COBRiskCodes:FirstYearOfAccount","2011"},
                    {5211,"F2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5212,"F3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5213,"F4","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5214,"F5","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5215,"FA","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5216,"FG","COBRiskCodes:FirstYearOfAccount","2001"},
                    {5217,"FM","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5218,"G","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5219,"GC","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5220,"GH","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5221,"GM","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5222,"GN","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5223,"GS","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5224,"GT","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5225,"GX","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5226,"H2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5227,"H3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5228,"HA","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5229,"HP","COBRiskCodes:FirstYearOfAccount","1993"},
                    {5230,"JB","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5231,"KA","COBRiskCodes:FirstYearOfAccount","1995"},
                    {5232,"KB","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5233,"KC","COBRiskCodes:FirstYearOfAccount","1995"},
                    {5234,"KG","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5235,"KM","COBRiskCodes:FirstYearOfAccount","1995"},
                    {5236,"KP","COBRiskCodes:FirstYearOfAccount","2013"},
                    {5237,"KS","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5238,"KT","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5239,"KX","COBRiskCodes:FirstYearOfAccount","1995"},
                    {5240,"L2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5241,"L3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5242,"LE","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5243,"LJ","COBRiskCodes:FirstYearOfAccount","1997"},
                    {5244,"M2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5245,"M3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5246,"M4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5247,"M5","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5248,"M6","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5249,"MF","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5250,"MG","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5251,"MH","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5252,"MI","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5253,"MP","COBRiskCodes:FirstYearOfAccount","1998"},
                    {5254,"N","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5255,"NA","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5256,"NB","COBRiskCodes:FirstYearOfAccount","2001"},
                    {5257,"NC","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5258,"NL","COBRiskCodes:FirstYearOfAccount","1998"},
                    {5259,"NP","COBRiskCodes:FirstYearOfAccount","1998"},
                    {5260,"NR","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5261,"NS","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5262,"NV","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5263,"NX","COBRiskCodes:FirstYearOfAccount","1997"},
                    {5264,"O","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5265,"P","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5266,"P2","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5267,"P3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5268,"P4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5269,"P5","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5270,"P6","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5271,"P7","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5272,"PB","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5273,"PC","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5274,"PF","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5275,"PG","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5276,"PN","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5277,"PQ","COBRiskCodes:FirstYearOfAccount","2000"},
                    {5278,"PR","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5279,"PU","COBRiskCodes:FirstYearOfAccount","2001"},
                    {5280,"PZ","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5281,"Q","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5282,"RX","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5283,"SA","COBRiskCodes:FirstYearOfAccount","2014"},
                    {5284,"SB","COBRiskCodes:FirstYearOfAccount","1995"},
                    {5285,"SC","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5286,"SL","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5287,"SO","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5288,"SR","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5289,"T","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5290,"TC","COBRiskCodes:FirstYearOfAccount","1997"},
                    {5291,"TL","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5292,"TO","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5293,"TR","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5294,"TS","COBRiskCodes:FirstYearOfAccount","2005"},
                    {5295,"TT","COBRiskCodes:FirstYearOfAccount","2016"},
                    {5296,"TU","COBRiskCodes:FirstYearOfAccount","1999"},
                    {5297,"TW","COBRiskCodes:FirstYearOfAccount","2013"},
                    {5298,"TX","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5299,"UA","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5300,"UC","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5301,"UR","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5302,"US","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5303,"V","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5304,"VL","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5305,"VX","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5306,"W","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5307,"W3","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5308,"W4","COBRiskCodes:FirstYearOfAccount","2004"},
                    {5309,"W5","COBRiskCodes:FirstYearOfAccount","2010"},
                    {5310,"W6","COBRiskCodes:FirstYearOfAccount","2010"},
                    {5311,"WA","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5312,"WB","COBRiskCodes:FirstYearOfAccount","2005"},
                    {5313,"WL","COBRiskCodes:FirstYearOfAccount","1997"},
                    {5314,"WX","COBRiskCodes:FirstYearOfAccount","1992"},
                    {5315,"X1","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5316,"X2","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5317,"X3","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5318,"XA","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5319,"XC","COBRiskCodes:FirstYearOfAccount","1998"},
                    {5320,"XE","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5321,"XF","COBRiskCodes:FirstYearOfAccount","2010"},
                    {5322,"XG","COBRiskCodes:FirstYearOfAccount","2010"},
                    {5323,"XH","COBRiskCodes:FirstYearOfAccount","2012"},
                    {5324,"XJ","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5325,"XM","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5326,"XN","COBRiskCodes:FirstYearOfAccount","2013"},
                    {5327,"XQ","COBRiskCodes:FirstYearOfAccount","2019"},
                    {5328,"XR","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5329,"XT","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5330,"XU","COBRiskCodes:FirstYearOfAccount","2008"},
                    {5331,"XY","COBRiskCodes:FirstYearOfAccount","1991"},
                    {5332,"1E","COBRiskCodes:LastYearOfAccount","9999"},
                    {5333,"1T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5334,"2E","COBRiskCodes:LastYearOfAccount","9999"},
                    {5335,"2T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5336,"3E","COBRiskCodes:LastYearOfAccount","9999"},
                    {5337,"3T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5338,"4E","COBRiskCodes:LastYearOfAccount","9999"},
                    {5339,"4T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5340,"5T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5341,"6T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5342,"7T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5343,"8T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5344,"AG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5345,"AO","COBRiskCodes:LastYearOfAccount","9999"},
                    {5346,"AP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5347,"AW","COBRiskCodes:LastYearOfAccount","9999"},
                    {5348,"B","COBRiskCodes:LastYearOfAccount","9999"},
                    {5349,"B2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5350,"B3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5351,"B4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5352,"B5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5353,"BB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5354,"BD","COBRiskCodes:LastYearOfAccount","9999"},
                    {5355,"CB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5356,"CC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5357,"CF","COBRiskCodes:LastYearOfAccount","9999"},
                    {5358,"CR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5359,"CT","COBRiskCodes:LastYearOfAccount","9999"},
                    {5360,"CY","COBRiskCodes:LastYearOfAccount","9999"},
                    {5361,"CZ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5362,"D2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5363,"D3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5364,"D4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5365,"D5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5366,"D6","COBRiskCodes:LastYearOfAccount","9999"},
                    {5367,"D7","COBRiskCodes:LastYearOfAccount","9999"},
                    {5368,"D8","COBRiskCodes:LastYearOfAccount","9999"},
                    {5369,"D9","COBRiskCodes:LastYearOfAccount","9999"},
                    {5370,"DC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5371,"E2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5372,"E3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5373,"E4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5374,"E5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5375,"E6","COBRiskCodes:LastYearOfAccount","9999"},
                    {5376,"E7","COBRiskCodes:LastYearOfAccount","9999"},
                    {5377,"E8","COBRiskCodes:LastYearOfAccount","9999"},
                    {5378,"E9","COBRiskCodes:LastYearOfAccount","9999"},
                    {5379,"EA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5380,"EB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5381,"EC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5382,"EF","COBRiskCodes:LastYearOfAccount","9999"},
                    {5383,"EG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5384,"EH","COBRiskCodes:LastYearOfAccount","9999"},
                    {5385,"EM","COBRiskCodes:LastYearOfAccount","9999"},
                    {5386,"EN","COBRiskCodes:LastYearOfAccount","9999"},
                    {5387,"EP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5388,"EY","COBRiskCodes:LastYearOfAccount","9999"},
                    {5389,"EZ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5390,"F2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5391,"F3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5392,"F4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5393,"F5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5394,"FA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5395,"FG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5396,"FM","COBRiskCodes:LastYearOfAccount","9999"},
                    {5397,"G","COBRiskCodes:LastYearOfAccount","9999"},
                    {5398,"GC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5399,"GH","COBRiskCodes:LastYearOfAccount","9999"},
                    {5400,"GM","COBRiskCodes:LastYearOfAccount","9999"},
                    {5401,"GN","COBRiskCodes:LastYearOfAccount","9999"},
                    {5402,"GS","COBRiskCodes:LastYearOfAccount","9999"},
                    {5403,"GT","COBRiskCodes:LastYearOfAccount","9999"},
                    {5404,"GX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5405,"H2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5406,"H3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5407,"HA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5408,"HP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5409,"JB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5410,"KA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5411,"KB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5412,"KC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5413,"KG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5414,"KM","COBRiskCodes:LastYearOfAccount","9999"},
                    {5415,"KP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5416,"KS","COBRiskCodes:LastYearOfAccount","9999"},
                    {5417,"KT","COBRiskCodes:LastYearOfAccount","9999"},
                    {5418,"KX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5419,"L2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5420,"L3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5421,"LE","COBRiskCodes:LastYearOfAccount","9999"},
                    {5422,"LJ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5423,"M2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5424,"M3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5425,"M4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5426,"M5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5427,"M6","COBRiskCodes:LastYearOfAccount","9999"},
                    {5428,"MF","COBRiskCodes:LastYearOfAccount","9999"},
                    {5429,"MG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5430,"MH","COBRiskCodes:LastYearOfAccount","9999"},
                    {5431,"MI","COBRiskCodes:LastYearOfAccount","9999"},
                    {5432,"MP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5433,"N","COBRiskCodes:LastYearOfAccount","9999"},
                    {5434,"NA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5435,"NB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5436,"NC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5437,"NL","COBRiskCodes:LastYearOfAccount","9999"},
                    {5438,"NP","COBRiskCodes:LastYearOfAccount","9999"},
                    {5439,"NR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5440,"NS","COBRiskCodes:LastYearOfAccount","9999"},
                    {5441,"NV","COBRiskCodes:LastYearOfAccount","9999"},
                    {5442,"NX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5443,"O","COBRiskCodes:LastYearOfAccount","9999"},
                    {5444,"P","COBRiskCodes:LastYearOfAccount","9999"},


                });

            migrationBuilder.InsertData(
                 table: "ReferenceDataItems",
                 columns: new[] { "ID", "Key", "Path", "Value" },
                 values: new object[,]
                 {
                    {5445,"P2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5446,"P3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5447,"P4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5448,"P5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5449,"P6","COBRiskCodes:LastYearOfAccount","9999"},
                    {5450,"P7","COBRiskCodes:LastYearOfAccount","9999"},
                    {5451,"PB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5452,"PC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5453,"PF","COBRiskCodes:LastYearOfAccount","9999"},
                    {5454,"PG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5455,"PN","COBRiskCodes:LastYearOfAccount","9999"},
                    {5456,"PQ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5457,"PR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5458,"PU","COBRiskCodes:LastYearOfAccount","9999"},
                    {5459,"PZ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5460,"Q","COBRiskCodes:LastYearOfAccount","9999"},
                    {5461,"RX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5462,"SA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5463,"SB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5464,"SC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5465,"SL","COBRiskCodes:LastYearOfAccount","9999"},
                    {5466,"SO","COBRiskCodes:LastYearOfAccount","9999"},
                    {5467,"SR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5468,"T","COBRiskCodes:LastYearOfAccount","9999"},
                    {5469,"TC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5470,"TL","COBRiskCodes:LastYearOfAccount","9999"},
                    {5471,"TO","COBRiskCodes:LastYearOfAccount","9999"},
                    {5472,"TR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5473,"TS","COBRiskCodes:LastYearOfAccount","9999"},
                    {5474,"TT","COBRiskCodes:LastYearOfAccount","9999"},
                    {5475,"TU","COBRiskCodes:LastYearOfAccount","9999"},
                    {5476,"TW","COBRiskCodes:LastYearOfAccount","9999"},
                    {5477,"TX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5478,"UA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5479,"UC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5480,"UR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5481,"US","COBRiskCodes:LastYearOfAccount","9999"},
                    {5482,"V","COBRiskCodes:LastYearOfAccount","9999"},
                    {5483,"VL","COBRiskCodes:LastYearOfAccount","9999"},
                    {5484,"VX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5485,"W","COBRiskCodes:LastYearOfAccount","9999"},
                    {5486,"W3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5487,"W4","COBRiskCodes:LastYearOfAccount","9999"},
                    {5488,"W5","COBRiskCodes:LastYearOfAccount","9999"},
                    {5489,"W6","COBRiskCodes:LastYearOfAccount","9999"},
                    {5490,"WA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5491,"WB","COBRiskCodes:LastYearOfAccount","9999"},
                    {5492,"WL","COBRiskCodes:LastYearOfAccount","9999"},
                    {5493,"WX","COBRiskCodes:LastYearOfAccount","9999"},
                    {5494,"X1","COBRiskCodes:LastYearOfAccount","9999"},
                    {5495,"X2","COBRiskCodes:LastYearOfAccount","9999"},
                    {5496,"X3","COBRiskCodes:LastYearOfAccount","9999"},
                    {5497,"XA","COBRiskCodes:LastYearOfAccount","9999"},
                    {5498,"XC","COBRiskCodes:LastYearOfAccount","9999"},
                    {5499,"XE","COBRiskCodes:LastYearOfAccount","9999"},
                    {5500,"XF","COBRiskCodes:LastYearOfAccount","9999"},
                    {5501,"XG","COBRiskCodes:LastYearOfAccount","9999"},
                    {5502,"XH","COBRiskCodes:LastYearOfAccount","9999"},
                    {5503,"XJ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5504,"XM","COBRiskCodes:LastYearOfAccount","9999"},
                    {5505,"XN","COBRiskCodes:LastYearOfAccount","9999"},
                    {5506,"XQ","COBRiskCodes:LastYearOfAccount","9999"},
                    {5507,"XR","COBRiskCodes:LastYearOfAccount","9999"},
                    {5508,"XT","COBRiskCodes:LastYearOfAccount","9999"},
                    {5509,"XU","COBRiskCodes:LastYearOfAccount","9999"},
                    {5510,"XY","COBRiskCodes:LastYearOfAccount","9999"},
                    {5511,"1E","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5512,"1T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5513,"2E","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5514,"2T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5515,"3E","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5516,"3T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5517,"4E","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5518,"4T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5519,"5T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5520,"6T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5521,"7T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5522,"8T","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5523,"AG","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty, including stop-loss"},
                    {5524,"AO","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5525,"AP","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5526,"AW","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5527,"B","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5528,"B2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5529,"B3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5530,"B4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5531,"B5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5532,"BB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5533,"BD","COBRiskCodes:TypeOfPlacement","Direct"},
                    {5534,"CB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty."},
                    {5535,"CC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5536,"CF","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5537,"CR","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5538,"CT","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5539,"CY","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5540,"CZ","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5541,"D2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5542,"D3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5543,"D4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5544,"D5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5545,"D6","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5546,"D7","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5547,"D8","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5548,"D9","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5549,"DC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5550,"E2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5551,"E3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5552,"E4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5553,"E5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5554,"E6","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5555,"E7","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5556,"E8","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5557,"E9","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5558,"EA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5559,"EB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5560,"EC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5561,"EF","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5562,"EG","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5563,"EH","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5564,"EM","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5565,"EN","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5566,"EP ","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5567,"EY","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5568,"EZ","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5569,"F2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5570,"F3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5571,"F4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5572,"F5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5573,"FA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss "},
                    {5574,"FG","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5575,"FM","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5576,"G","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5577,"GC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5578,"GH","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5579,"GM","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5580,"GN","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5581,"GS","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5582,"GT","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5583,"GX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5584,"H2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5585,"H3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5586,"HA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5587,"HP","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5588,"JB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5589,"KA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5590,"KB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5591,"KC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5592,"KG","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5593,"KM","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5594,"KP","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5595,"KS","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5596,"KT","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5597,"KX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5598,"L2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5599,"L3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5600,"LE","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5601,"LJ","COBRiskCodes:TypeOfPlacement","Not applicable"},
                    {5602,"M2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5603,"M3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5604,"M4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5605,"M5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5606,"M6","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5607,"MF","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5608,"MG","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5609,"MH","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5610,"MI","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5611,"MP","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5612,"N","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5613,"NA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5614,"NB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5615,"NC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5616,"NL","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5617,"NP","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5618,"NR","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5619,"NS","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5620,"NV","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5621,"NX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5622,"O","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5623,"P","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty as applicable"},
                    {5624,"P2","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional"},
                    {5625,"P3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional"},
                    {5626,"P4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional"},
                    {5627,"P5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional"},
                    {5628,"P6","COBRiskCodes:TypeOfPlacement","Direct, Facultative Excess Loss"},
                    {5629,"P7","COBRiskCodes:TypeOfPlacement","Direct, Facultative Excess Loss"},
                    {5630,"PB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5631,"PC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5632,"PF","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5633,"PG","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5634,"PN","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5635,"PQ","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5636,"PR","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5637,"PU","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5638,"PZ","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5639,"Q","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5640,"RX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5641,"SA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5642,"SB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5643,"SC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5644,"SL","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5645,"SO","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5646,"SR","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5647,"T","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5648,"TC","COBRiskCodes:TypeOfPlacement","Not applicable"},
                    {5649,"TL","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Excess of Loss Treaty, Proportional Treaty"},
                    {5650,"TO","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5651,"TR","COBRiskCodes:TypeOfPlacement","Proportional Treaty"},
                    {5652,"TS","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5653,"TT","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5654,"TU","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss"},
                    {5655,"TW","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5656,"TX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5657,"UA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5658,"UC","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5659,"UR","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5660,"US","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5661,"V","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5662,"VL","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5663,"VX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5664,"W","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5665,"W3","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5666,"W4","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5667,"W5","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5668,"W6","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5669,"WA","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5670,"WB","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5671,"WL","COBRiskCodes:TypeOfPlacement","Direct, Facultative Proportional, Facultative Excess Loss, Proportional Treaty"},
                    {5672,"WX","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5673,"X1","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5674,"X2","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5675,"X3","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5676,"XA","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5677,"XC","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5678,"XE","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5679,"XF","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5680,"XG","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5681,"XH","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5682,"XJ","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5683,"XM","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5684,"XN","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5685,"XQ","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5686,"XR","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5687,"XT","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5688,"XU","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5689,"XY","COBRiskCodes:TypeOfPlacement","Excess of Loss Treaty"},
                    {5690,"1E","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5691,"1T","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5692,"2E","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5693,"2T","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5694,"3E","COBRiskCodes:OECD"," "},
                    {5695,"3T","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5696,"4E","COBRiskCodes:OECD"," "},
                    {5697,"4T","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5698,"5T","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5699,"6T","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5700,"7T","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5701,"8T","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5702,"AG","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5703,"AO","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5704,"AP","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5705,"AW","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5706,"B","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5707,"B2","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5708,"B3","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5709,"B4","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5710,"B5","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5711,"BB","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5712,"BD","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5713,"CB","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5714,"CC","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5715,"CF","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5716,"CR","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5717,"CT","COBRiskCodes:OECD","GOODS IN TRANSIT"},
                    {5718,"CY","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5719,"CZ","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5720,"D2","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5721,"D3","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5722,"D4","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5723,"D5","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5724,"D6","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5725,"D7","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5726,"D8","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5727,"D9","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5728,"DC","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5729,"E2","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5730,"E3","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5731,"E4","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5732,"E5","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5733,"E6","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5734,"E7","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5735,"E8","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5736,"E9","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5737,"EA","COBRiskCodes:OECD"," "},
                    {5738,"EB","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5739,"EC","COBRiskCodes:OECD"," "},
                    {5740,"EF","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5741,"EG","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5742,"EH","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5743,"EM","COBRiskCodes:OECD"," "},
                    {5744,"EN","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5745,"EP ","COBRiskCodes:OECD"," "},
                    {5746,"EY","COBRiskCodes:OECD"," "},
                    {5747,"EZ","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5748,"F2","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5749,"F3","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5750,"F4","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5751,"F5","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5752,"FA","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5753,"FG","COBRiskCodes:OECD"," "},
                    {5754,"FM","COBRiskCodes:OECD"," "},
                    {5755,"G","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5756,"GC","COBRiskCodes:OECD"," "},
                    {5757,"GH","COBRiskCodes:OECD"," "},
                    {5758,"GM","COBRiskCodes:OECD"," "},
                    {5759,"GN","COBRiskCodes:OECD"," "},
                    {5760,"GS","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5761,"GT","COBRiskCodes:OECD"," "},
                    {5762,"GX","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5763,"H2","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5764,"H3","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5765,"HA","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5766,"HP","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5767,"JB","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5768,"KA","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5769,"KB","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5770,"KC","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5771,"KG","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5772,"KM","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5773,"KP","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5774,"KS","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5775,"KT","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5776,"KX","COBRiskCodes:OECD","ACCIDENT AND HEALTH"},
                    {5777,"L2","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5778,"L3","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5779,"LE","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5780,"LJ","COBRiskCodes:OECD"," "},
                    {5781,"M2","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5782,"M3","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5783,"M4","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5784,"M5","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5785,"M6","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5786,"MF","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5787,"MG","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5788,"MH","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5789,"MI","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5790,"MP","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5791,"N","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5792,"NA","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5793,"NB","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5794,"NC","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5795,"NL","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5796,"NP","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5797,"NR","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5798,"NS","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5799,"NV","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5800,"NX","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5801,"O","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5802,"P","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5803,"P2","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5804,"P3","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5805,"P4","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5806,"P5","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5807,"P6","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5808,"P7","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5809,"PB","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5810,"PC","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5811,"PF","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5812,"PG","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5813,"PN","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5814,"PQ","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5815,"PR","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5816,"PU","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5817,"PZ","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5818,"Q","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5819,"RX","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5820,"SA","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5821,"SB","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5822,"SC","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5823,"SL","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5824,"SO","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5825,"SR","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5826,"T","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5827,"TC","COBRiskCodes:OECD"," "},
                    {5828,"TL","COBRiskCodes:OECD","LONG TERM BUSINESS"},
                    {5829,"TO","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5830,"TR","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5831,"TS","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5832,"TT","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5833,"TU","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5834,"TW","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5835,"TX","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5836,"UA","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5837,"UC","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5838,"UR","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5839,"US","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5840,"V","COBRiskCodes:OECD","GOODS IN TRANSIT"},
                    {5841,"VL","COBRiskCodes:OECD","GOODS IN TRANSIT"},
                    {5842,"VX","COBRiskCodes:OECD","GOODS IN TRANSIT"},
                    {5843,"W","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5844,"W3","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5845,"W4","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5846,"W5","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5847,"W6","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5848,"WA","COBRiskCodes:OECD","PECUNIARY LOSS"},
                    {5849,"WB","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5850,"WL","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5851,"WX","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5852,"X1","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5853,"X2","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5854,"X3","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5855,"XA","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5856,"XC","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5857,"XE","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5858,"XF","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5859,"XG","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5860,"XH","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5861,"XJ","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5862,"XM","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5863,"XN","COBRiskCodes:OECD","MTR VHCLE DMGE & LIAB"},
                    {5864,"XQ","COBRiskCodes:OECD","GENERAL LIABILITY"},
                    {5865,"XR","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5866,"XT","COBRiskCodes:OECD","SHIPS DMGE & LIABILITY"},
                    {5867,"XU","COBRiskCodes:OECD","PROPERTY DAMAGE"},
                    {5868,"XY","COBRiskCodes:OECD","AIRCRAFT DMGE & LIAB"},
                    {5869,"1E","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE PROPERTY"},
                    {5870,"1T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM ACCIDENT AND HEALTH"},
                    {5871,"2E","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY OFFSHORE LIABILITY"},
                    {5872,"2T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM AVIATION"},
                    {5873,"3E","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE PROPERTY"},
                    {5874,"3T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM MARINE"},
                    {5875,"4E","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM ENERGY ONSHORE LIABILITY"},
                    {5876,"4T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM MISC AND PECUNIARY LOSS"},
                    {5877,"5T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM MOTOR"},
                    {5878,"6T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM PROPERTY"},
                    {5879,"7T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM THIRD PARTY LIABILITY"},
                    {5880,"8T","COBRiskCodes:Generic:49:Description","OVERSEAS LEG TERRORISM TRANSPORT"},
                    {5881,"AG","COBRiskCodes:Generic:60:Description","AGRICULTURAL CROP AND FORESTRY XOL TREATY INCL STOP LOSS"},
                    {5882,"AO","COBRiskCodes:Generic:7:Description","AVIATION PREMISES LEGAL LIABILITY NO PRODUCTS"},
                    {5883,"AP","COBRiskCodes:Generic:7:Description","AVIATION OR AEROSPACE PRODUCTS LEGAL LIABILITY"},
                    {5884,"AW","COBRiskCodes:Generic:8:Description","HULLS OF AIRCRAFT WAR OR CONFISCATION NO ACV"},
                    {5885,"B","COBRiskCodes:Generic:34:Description","Vessels TLO IV LOH and Containers Excl. WRO"},
                    {5886,"B2","COBRiskCodes:Generic:55:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY IN USA"},
                    {5887,"B3","COBRiskCodes:Generic:55:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY IN USA"},
                    {5888,"B4","COBRiskCodes:Generic:56:Description","PHYS DAMAGE BINDER FOR PRIVATE PPTY EXCL USA"},
                    {5889,"B5","COBRiskCodes:Generic:56:Description","PHYS DAMAGE BINDER FOR COMMERCIAL PPTY EXCL USA"},
                    {5890,"BB","COBRiskCodes:Generic:26:Description","FIDELITY COMPUTER CRIME AND BANKERS POLICIES"},
                    {5891,"BD","COBRiskCodes:Generic:49:Description","TERRORISM POOL RE"},
                    {5892,"CB","COBRiskCodes:Generic:50:Description","ENGINEERING ANNUAL RENEWABLE INCL CAR EAR MB CPE B&M EEI AND TREATY LOD"},
                    {5893,"CC","COBRiskCodes:Generic:50:Description","ENGINEERING SINGLE PROJECT NON RENEWABLE INCL CAR EAR AND TREATY RAD"},
                    {5894,"CF","COBRiskCodes:Generic:51:Description","CONTRACT FRUSTRATION FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {5895,"CR","COBRiskCodes:Generic:51:Description","CREDIT RISK FROM 2019 IN ACCORD MKT BULLETIN Y5191"},
                    {5896,"CT","COBRiskCodes:Generic:35:Description","ARMOURED CARRIERS AND CASH IN TRANSIT"},
                    {5897,"CY","COBRiskCodes:Generic:27:Description","Cyber Security Data and Privacy Breach"},
                    {5898,"CZ","COBRiskCodes:Generic:27:Description","CYBER SECURITY AND PROPERTY DAMAGE"},
                    {5899,"D2","COBRiskCodes:Generic:28:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS IN USA"},
                    {5900,"D3","COBRiskCodes:Generic:29:Description","D AND O LIAB EXCL FINANCIAL INSTITUTIONS EXCL USA "},
                    {5901,"D4","COBRiskCodes:Generic:30:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS INCL USA"},
                    {5902,"D5","COBRiskCodes:Generic:31:Description","D AND O LIAB FOR FINANCIAL INSTITUTIONS EXCL USA"},
                    {5903,"D6","COBRiskCodes:Generic:28:Description","Employment Practices Liability Insurance (EPLI) Incl. US"},
                    {5904,"D7","COBRiskCodes:Generic:29:Description","Employment Practices Liability Insurance (EPLI) Excl. US"},
                    {5905,"D8","COBRiskCodes:Generic:28:Description","Transactional Liability insurance Incl. US"},
                    {5906,"D9","COBRiskCodes:Generic:29:Description","Transactional Liability insurance Excl. US"},
                    {5907,"DC","COBRiskCodes:Generic:57:Description","DIFFERENCE IN CONDITIONS"},
                    {5908,"E2","COBRiskCodes:Generic:32:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS INCL USA"},
                    {5909,"E3","COBRiskCodes:Generic:33:Description","PROF INDTY E&O FOR LEGAL PROFESSIONS EXCL USA"},
                    {5910,"E4","COBRiskCodes:Generic:32:Description","PROF INDTY E&O FOR ACCOUNTANTS INCL USA"},
                    {5911,"E5","COBRiskCodes:Generic:33:Description","PROF INDTY E&O FOR ACCOUNTANTS EXCL USA"},
                    {5912,"E6","COBRiskCodes:Generic:32:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES INCL USA"},
                    {5913,"E7","COBRiskCodes:Generic:33:Description","PROF INDTY E&O ARCHITECTS, ENGINEERS, OTHER CONSTRUCTION RELATED INDUSTRIES EXCL USA"},
                    {5914,"E8","COBRiskCodes:Generic:32:Description","MISC PROF IND E&O INCL USA EXCL \"E2\" \"E4\" \"E6\" CODES"},
                    {5915,"E9","COBRiskCodes:Generic:33:Description","MISC PROF IND E&O EXCL USA EXCL \"E3\" \"E5\" \"E7\" CODES"},
                    {5916,"EA","COBRiskCodes:Generic:19:Description","ENERGY LIABILITY ONSHORE CLAIMS MADE"},
                    {5917,"EB","COBRiskCodes:Generic:19:Description","ENERGY LIABILITY ONSHORE ALL OTHER"},
                    {5918,"EC","COBRiskCodes:Generic:20:Description","ENERGY CONSTRUCTION OFFSHORE PROP AND SEARCH PROD VSSLS EXCL WRO"},
                    {5919,"EF","COBRiskCodes:Generic:21:Description","ENERGY ONSHORE PROPERTY"},
                    {5920,"EG","COBRiskCodes:Generic:22:Description","ENERGY LIABILITY OFFSHORE CLAIMS MADE"},
                    {5921,"EH","COBRiskCodes:Generic:22:Description","ENERGY LIABILITY OFFSHORE ALL OTHER"},
                    {5922,"EM","COBRiskCodes:Generic:23:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {5923,"EN","COBRiskCodes:Generic:23:Description","ENERGY SEARCH PROD VSSLS AND OFFSHORE PROP EXCL GOM WIND EXCL WRO EXCL CONSTRUCTION"},
                    {5924,"EP","COBRiskCodes:Generic:13:Description","Environmental Impairment Liability or NM Pollution Liability"},
                    {5925,"EY","COBRiskCodes:Generic:23:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL GOM  WIND"},
                    {5926,"EZ","COBRiskCodes:Generic:23:Description","ENERGY OPERATORS XTRA EXPENSES AND CONTROL OF WELL EXCL GOM WIND"},
                    {5927,"F2","COBRiskCodes:Generic:30:Description","PROF INDTY E&O FOR FIN INSTITUTIONS INCL USA"},
                    {5928,"F3","COBRiskCodes:Generic:31:Description","PROF INDTY E&O FOR FIN INSTITUTIONS EXCL USA"},
                    {5929,"F4","COBRiskCodes:Generic:32:Description","Technology and Telecommunications E&O Incl. US"},
                    {5930,"F5","COBRiskCodes:Generic:33:Description","Technology and Telecommunications E&O Excl. US"},
                    {5931,"FA","COBRiskCodes:Generic:36:Description","FINE ART"},
                    {5932,"FG","COBRiskCodes:Generic:51:Description","FINANCIAL GUARANTEE (authorised syndicates only)"},
                    {5933,"FM","COBRiskCodes:Generic:51:Description","MORTGAGE INDEMNITY - From 01/01/05 also includes business previously coded \"BS\" "},
                    {5934,"G","COBRiskCodes:Generic:37:Description","MARINE LEGAL LIAB ALL OTHER NO CARGO EXCL WRO"},
                    {5935,"GC","COBRiskCodes:Generic:37:Description","MARINE LEGAL LIAB CLAIMS MADE NO CARGO EXCL WRO"},
                    {5936,"GH","COBRiskCodes:Generic:43:Description","HOSPITALS/ INSTITUTIONAL HEALTHCARE INSURANCE RISKS IN USA"},
                    {5937,"GM","COBRiskCodes:Generic:43:Description","MEDICAL MALPRACTICE EXCL USA "},
                    {5938,"GN","COBRiskCodes:Generic:43:Description","NURSING HOMES/ LONG-TERM AND ALLIED HEALTHCARE/OTHER MEDICAL MALPRACTICE RISKS IN USA"},
                    {5939,"GS","COBRiskCodes:Generic:35:Description","GENERAL SPECIE INCLUDING VAULT RISK"},
                    {5940,"GT","COBRiskCodes:Generic:43:Description","MEDICAL MALPRACTICE TREATY XOL IN USA"},
                    {5941,"GX","COBRiskCodes:Generic:38:Description","XOL MARINE LEGAL LIAB EXCL CARGO ALL OTHER EXCL WRO"},
                    {5942,"H2","COBRiskCodes:Generic:9:Description","AIRLINE HULL"},
                    {5943,"H3","COBRiskCodes:Generic:10:Description","GENERAL AVIATION HULL"},
                    {5944,"HA","COBRiskCodes:Generic:60:Description","AGRICULTURAL CROP AND FORESTRY EXCL XOL TREATY AND STOP LOSS"},
                    {5945,"HP","COBRiskCodes:Generic:56:Description","UK HOUSEHOLD BUSINESS"},
                    {5946,"JB","COBRiskCodes:Generic:35:Description","JEWELLERS BLOCK JEWELLERY ETC INCL ROBBERY - From 01/01/05 also includes business previously coded \"FR\" "},
                    {5947,"KA","COBRiskCodes:Generic:1:Description","PERSONAL ACCIDENT AND HEALTH CARVE OUT"},
                    {5948,"KB","COBRiskCodes:Generic:1:Description","DISABILITY LONG TERM BENEFIT"},
                    {5949,"KC","COBRiskCodes:Generic:1:Description","PERSONAL ACCIDENT AND HEALTH CREDITOR  DISABILITY"},
                    {5950,"KG","COBRiskCodes:Generic:1:Description","Personal Accident and Health Excl. K&R, KP KS AND KT CODES"},
                    {5951,"KM","COBRiskCodes:Generic:2:Description","MEDICAL EXPENSES INCL XS SPEC AND AGG SELF FUND"},
                    {5952,"KP","COBRiskCodes:Generic:1:Description","MARITIME EXTORTION EXCL KIDNAP AND RANSOM WRITTEN UNDER 'P'"},
                    {5953,"KS","COBRiskCodes:Generic:1:Description","PA AND HEALTH INCL SPORTS DIS OTHER THAN ACC DEATH"},
                    {5954,"KT","COBRiskCodes:Generic:1:Description","PA AND HEALTH FOR TRAVEL PACKAGE SCHEMES"},
                    {5955,"KX","COBRiskCodes:Generic:3:Description","PERSONAL ACCIDENT AND HEALTH CATASTROPHE XL - From 01/01/08 also includes business previously coded \"KL\""},
                    {5956,"L2","COBRiskCodes:Generic:9:Description","AIRLINE LIABILITY"},
                    {5957,"L3","COBRiskCodes:Generic:10:Description","GENERAL AVIATION LIABILITY"},
                    {5958,"LE","COBRiskCodes:Generic:52:Description","LEGAL EXPENSES    "},
                    {5959,"M2","COBRiskCodes:Generic:44:Description","UK MOTOR COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {5960,"M3","COBRiskCodes:Generic:44:Description","UK MOTOR COMP FOR FLEET AND COMMERCIAL VEHICLE"},
                    {5961,"M4","COBRiskCodes:Generic:44:Description","OTHER UK MOTOR COMP AND NON COMP EXCL \"M2\" AND \"M3\" CODES - From 01/01/08 includes business previously coded \"M7\""},
                    {5962,"M5","COBRiskCodes:Generic:44:Description","UK MOTOR NON COMP FOR PRIVATE CAR INCL MOTORCYCLE"},
                    {5963,"M6","COBRiskCodes:Generic:44:Description","UK MOTOR NON COMP FOR FLEET AND COMM VEHICLE"},
                    {5964,"MF","COBRiskCodes:Generic:45:Description","OVERSEAS MOTOR DAM AND TPL EXCL USA CAN EU AND EEA - From 01/01/05 also includes business previously coded \"MD\" and \"ME\""},
                    {5965,"MG","COBRiskCodes:Generic:45:Description","USA AND CANADA MOTOR VEHICLE PHYSICAL DAMAGE"},
                    {5966,"MH","COBRiskCodes:Generic:45:Description","USA AND CANADA MOTOR VEHICLE THIRD PARTY LIABILITY"},
                    {5967,"MI","COBRiskCodes:Generic:45:Description","USA AND CANADA MOTOR DAMAGE AND 3RD PARTY LIAB"},
                    {5968,"MP","COBRiskCodes:Generic:45:Description","EU AND EEA MOTOR PD AND TPL EXCL UK - From 01/01/05 also includes business previously coded \"MM\" and \"MN\""},
                    {5969,"N","COBRiskCodes:Generic:53:Description","LIVESTOCK"},
                    {5970,"NA","COBRiskCodes:Generic:13:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA - FROM 2019 EXCL BINDERS "},
                    {5971,"NB","COBRiskCodes:Generic:53:Description","BLOODSTOCK"},
                    {5972,"NC","COBRiskCodes:Generic:13:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA - FROM 2019 EXCL BINDERS"},
                    {5973,"NL","COBRiskCodes:Generic:24:Description","NUCLEAR LIABILITY FROM 2019 LIMITATION NOT GREATER THAN 10 YEARS"},
                    {5974,"NP","COBRiskCodes:Generic:24:Description","NUCLEAR PROPERTY DAMAGE"},
                    {5975,"NR","COBRiskCodes:Generic:13:Description","NM GENERAL AND MISC LIABILITY ALL OTHER  EXCL USA -  BINDERS ONLY"},
                    {5976,"NS","COBRiskCodes:Generic:13:Description","NM GENERAL AND MISC LIAB CLAIMS MADE EXCL USA -  BINDERS ONLY"},
                    {5977,"NV","COBRiskCodes:Generic:24:Description","NUCLEAR LIABILITY LIMITATION EXCESS OF 10 YEARS"},
                    {5978,"NX","COBRiskCodes:Generic:53:Description","LIVESTOCK EXCESS OF LOSS"},
                    {5979,"O","COBRiskCodes:Generic:39:Description","YACHTS INCL WAR EXCL WRO"},
                    {5980,"P","COBRiskCodes:Generic:4:Description","MISCELLANEOUS PECUNIARY LOSS - From 01/01/05 also includes business previously coded \"PE\" \"PP\" \"PS\" and \"PW\""},
                    {5981,"P2","COBRiskCodes:Generic:58:Description","PHYS DAMAGE FOR PRIM LAYER PPTY IN USA EXCL BINDERS"},
                    {5982,"P3","COBRiskCodes:Generic:59:Description","PHYS DAMAGE FOR PRIM LAYER PPTY EXCL USA EXCL BINDERS"},
                    {5983,"P4","COBRiskCodes:Generic:58:Description","PHYS DAMAGE FOR FULL VALUE PPTY IN USA EXCL BINDERS"},
                    {5984,"P5","COBRiskCodes:Generic:59:Description","PHYS DAMAGE FOR FULL VALUE PPTY EXCL USA EXCL BINDERS"},
                    {5985,"P6","COBRiskCodes:Generic:58:Description","PHYS DAMAGE FOR XS LAYER PPTY IN USA EXCL BINDERS"},
                    {5986,"P7","COBRiskCodes:Generic:59:Description","PHYS DAMAGE FOR XS LAYER PPTY EXCL USA EXCL BINDERS"},
                    {5987,"PB","COBRiskCodes:Generic:4:Description","PRODUCT RECALL"},
                    {5988,"PC","COBRiskCodes:Generic:5:Description","CANCELLATION AND ABANDONMENT"},
                    {5989,"PF","COBRiskCodes:Generic:5:Description","FILM INCLUDING FILM COMPLETION BONDS  "},
                    {5990,"PG","COBRiskCodes:Generic:25:Description","OPERATIONAL POWER GENERATION TRANSMISSION AND UTILITIES EXCL CONSTRUCTION "},
                    {5991,"PN","COBRiskCodes:Generic:5:Description","NON APPEARANCE"},
                    {5992,"PQ","COBRiskCodes:Generic:44:Description","ROADSIDE RESCUE     "},
                    {5993,"PR","COBRiskCodes:Generic:51:Description","POLITICAL RISK EXCL CONFISCATION VESSELS AIRCRAFT"},
                    {5994,"PU","COBRiskCodes:Generic:5:Description","MISCELLANEOUS CONTINGENCY - From 01/01/05 also includes business previously coded \"PO\""},
                    {5995,"PZ","COBRiskCodes:Generic:5:Description","PRIZE INDEMNITY INCLUDING HOLE IN ONE"},
                    {5996,"Q","COBRiskCodes:Generic:40:Description","CARGO WAR AND OR CONFISCATION RISKS ONLY"},
                    {5997,"RX","COBRiskCodes:Generic:8:Description","XOL HULLS OF AIRCRAFT WAR AND OR CONFIS RISKS ONLY "},
                    {5998,"SA","COBRiskCodes:Generic:51:Description","SEAFARERS ABANDONMENT (authorised syndicates only)"},
                    {5999,"SB","COBRiskCodes:Generic:51:Description","SURETY BOND REINSURANCE - From 01/01/05 also includes business previously coded \"FC\" or \"FS\" "},
                    {6000,"SC","COBRiskCodes:Generic:11:Description","SPACE RISKS LAUNCH COMMISSIONING PERIOD AND TRANSPOND OP - From 01/01/08 also includes business previously coded \"CX\""},
                    {6001,"SL","COBRiskCodes:Generic:11:Description","SPACE RISK LIABILITY NO PRODUCTS LEGAL LIABILITY"},
                    {6002,"SO","COBRiskCodes:Generic:11:Description","SPACE RISKS TRANSPONDER OPERATING"},
                    {6003,"SR","COBRiskCodes:Generic:38:Description","AGG STOP LOSS AND XOL MARINE OUTWARD WHOLE ACCOUNT"},
                    {6004,"T","COBRiskCodes:Generic:34:Description","Vessels Excl. TLO IV LOH Containers Shipbuilding and WRO"},
                    {6005,"TC","COBRiskCodes:Generic:46:Description","COMMERCIAL RITC"},
                    {6006,"TL","COBRiskCodes:Generic:6:Description","TEMPORARY LIFE AND PERMANENT HEALTH"},
                    {6007,"TO","COBRiskCodes:Generic:49:Description","OVERSEAS STAND ALONE TERROR EXCL \"1T\" to \"8T\" & \"1E\" to \"4E\""},
                    {6008,"TR","COBRiskCodes:Generic:61:Description","ALL RISK PHYSICAL OR LOSS DAMAGE  DIRECT PPNL RI"},
                    {6009,"TS","COBRiskCodes:Generic:34:Description","SHIPBUILDING EXCL ENERGY CONSTRUCTION"},
                    {6010,"TT","COBRiskCodes:Generic:4:Description","TITLE INSURANCE"},
                    {6011,"TU","COBRiskCodes:Generic:49:Description","UK STAND ALONE TERRORISM WHICH IS NON POOL RE"},
                    {6012,"TW","COBRiskCodes:Generic:49:Description","TERRORISM AND WAR ON LAND WHOLE ACCOUNT XOL TREATY RI INCL RI OF POOLS "},
                    {6013,"TX","COBRiskCodes:Generic:38:Description","XOL VESSELS SHIPBLDG ACV LOH INCL WAR EXCL WRO - From 01/01/05 also includes business previously coded \"OX\""},
                    {6014,"UA","COBRiskCodes:Generic:14:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - FROM 2019 EXCL BINDERS"},
                    {6015,"UC","COBRiskCodes:Generic:14:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA - FROM 2019 EXCL BINDERS"},
                    {6016,"UR","COBRiskCodes:Generic:14:Description","NM GENERAL AND MISC LIABILITY ALL OTHER INCL USA - BINDERS ONLY"},
                    {6017,"US","COBRiskCodes:Generic:14:Description","NM GENERAL AND MISC LIAB CLAIMS MADE INCL USA -  BINDERS ONLY"},
                    {6018,"V","COBRiskCodes:Generic:41:Description","CARGO ALL RISKS INCL WAR EXCL WRO"},
                    {6019,"VL","COBRiskCodes:Generic:41:Description","LEGAL LIAB CARGO AND PROP INCL CCC OF ASSURED EXCL WRO"},
                    {6020,"VX","COBRiskCodes:Generic:38:Description","XOL Cargo Incl. War Excl. WRO"},
                    {6021,"W","COBRiskCodes:Generic:40:Description","VESSELS WAR AND OR CONFISCATION EXCL BREACH VOYAGES"},
                    {6022,"W3","COBRiskCodes:Generic:48:Description","UK EMPLOYERS LIABILITY"},
                    {6023,"W4","COBRiskCodes:Generic:48:Description","INTL WORKERS COMP AND EMPLOYERS LIAB EXCL USA AND UK"},
                    {6024,"W5","COBRiskCodes:Generic:15:Description","US WORKERS COMPENSATION PER PERSON EXPOSED"},
                    {6025,"W6","COBRiskCodes:Generic:15:Description","US WORKERS COMPENSATION CATASTROPHE EXPOSED"},
                    {6026,"WA","COBRiskCodes:Generic:54:Description","EXTENDED WARRANTY - From 01/01/05 also includes business previously coded \"WS\""},
                    {6027,"WB","COBRiskCodes:Generic:40:Description","VESSELS HULL WAR BREACH VOYAGES ONLY"},
                    {6028,"WL","COBRiskCodes:Generic:49:Description","WAR ON LAND - From 01/01/05 also includes business previously coded \"QL\""},
                    {6029,"WX","COBRiskCodes:Generic:40:Description","XOL VESSELS  WAR AND OR CONFISCATION RISKS ONLY - From 01/01/05 also includes business previously coded \"QX\""},
                    {6030,"X1","COBRiskCodes:Generic:12:Description","AVIATION EXCESS OF LOSS ON EXCESS OF LOSS - From 01/01/05 also includes business previously coded \"XZ\""},
                    {6031,"X2","COBRiskCodes:Generic:38:Description","MARINE XOL ON XOL INCL WAR"},
                    {6032,"X3","COBRiskCodes:Generic:62:Description","NM PROP OR PECUNIARY LOSS XOL ON XOL RETROCESSION"},
                    {6033,"XA","COBRiskCodes:Generic:63:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN USA"},
                    {6034,"XC","COBRiskCodes:Generic:64:Description","PER RISK EXCESS OF LOSS PROP PECUNIARY LOSS REINS"},
                    {6035,"XE","COBRiskCodes:Generic:38:Description","ENERGY ACCOUNT XOL INCL WAR - From 01/01/05 also includes business previously coded \"X5\""},
                    {6036,"XF","COBRiskCodes:Generic:16:Description","NM LIABILITY EXCESS OF LOSS IN USA - FROM 2019 RISK EXPOSED"},
                    {6037,"XG","COBRiskCodes:Generic:17:Description","NM LIABILITY EXCESS OF LOSS CLAIMS MADE OR LOSSES DISCOVERED EXCL USA "},
                    {6038,"XH","COBRiskCodes:Generic:17:Description","NM LIABILITY EXCESS OF LOSS LOSSES OCCURRING EXCL USA "},
                    {6039,"XJ","COBRiskCodes:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN JAPAN "},
                    {6040,"XM","COBRiskCodes:Generic:18:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUSINESS IN UK"},
                    {6041,"XN","COBRiskCodes:Generic:18:Description","MOTOR WHOLE ACCOUNT EXCESS OF LOSS ORIGINAL BUISNESS OUTSIDE UK"},
                    {6042,"XQ","COBRiskCodes:Generic:16:Description","NM LIABILITY EXCESS OF LOSS IN USA - CLASH"},
                    {6043,"XR","COBRiskCodes:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN REST OF WORLD "},
                    {6044,"XT","COBRiskCodes:Generic:38:Description","MARINE WHOLE ACCOUNT XOL INCL WAR"},
                    {6045,"XU","COBRiskCodes:Generic:62:Description","NM PROPERTY OR PECUNIARY LOSS WHOLE ACCOUNT XOL IN ALL OF EUROPE INCL UK"},
                    {6046,"XY","COBRiskCodes:Generic:12:Description","AVIATION WHOLE ACCOUNT XOL INCL WAR EXCL XOL ON XOL - From 01/01/05 also includes business previously coded \"AR\" and \"AX\" - From 01/01/08 also includes business previously coded \"HX\""}

                 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReferenceDataItems",
                keyColumn: "ID",
                keyValue: 4478);

            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4479);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4480);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4481);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4482);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4483);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4484);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4485);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4486);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4487);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4488);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4489);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4490);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4491);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4492);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4493);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4494);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4495);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4496);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4497);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4498);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4499);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4500);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4501);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4502);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4503);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4504);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4505);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4506);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4507);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4508);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4509);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4510);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4511);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4512);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4513);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4514);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4515);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4516);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4517);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4518);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4519);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4520);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4521);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4522);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4523);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4524);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4525);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4526);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4527);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4528);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4529);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4530);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4531);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4532);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4533);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4534);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4535);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4536);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4537);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4538);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4539);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4540);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4541);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4542);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4543);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4544);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4545);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4546);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4547);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4548);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4549);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4550);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4551);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4552);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4553);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4554);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4555);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4556);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4557);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4558);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4559);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4560);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4561);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4562);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4563);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4564);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4565);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4566);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4567);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4568);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4569);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4570);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4571);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4572);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4573);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4574);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4575);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4576);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4577);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4578);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4579);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4580);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4581);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4582);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4583);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4584);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4585);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4586);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4587);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4588);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4589);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4590);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4591);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4592);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4593);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4594);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4595);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4596);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4597);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4598);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4599);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4600);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4601);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4602);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4603);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4604);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4605);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4606);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4607);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4608);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4609);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4610);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4611);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4612);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4613);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4614);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4615);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4616);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4617);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4618);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4619);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4620);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4621);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4622);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4623);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4624);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4625);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4626);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4627);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4628);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4629);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4630);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4631);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4632);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4633);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4634);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4635);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4636);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4637);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4638);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4639);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4640);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4641);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4642);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4643);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4644);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4645);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4646);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4647);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4648);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4649);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4650);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4651);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4652);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4653);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4654);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4655);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4656);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4657);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4658);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4659);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4660);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4661);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4662);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4663);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4664);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4665);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4666);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4667);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4668);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4669);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4670);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4671);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4672);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4673);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4674);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4675);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4676);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4677);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4678);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4679);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4680);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4681);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4682);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4683);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4684);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4685);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4686);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4687);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4688);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4689);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4690);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4691);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4692);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4693);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4694);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4695);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4696);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4697);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4698);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4699);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4700);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4701);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4702);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4703);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4704);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4705);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4706);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4707);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4708);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4709);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4710);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4711);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4712);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4713);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4714);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4715);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4716);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4717);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4718);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4719);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4720);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4721);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4722);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4723);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4724);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4725);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4726);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4727);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4728);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4729);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4730);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4731);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4732);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4733);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4734);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4735);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4736);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4737);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4738);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4739);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4740);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4741);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4742);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4743);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4744);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4745);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4746);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4747);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4748);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4749);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4750);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4751);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4752);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4753);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4754);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4755);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4756);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4757);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4758);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4759);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4760);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4761);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4762);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4763);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4764);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4765);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4766);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4767);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4768);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4769);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4770);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4771);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4772);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4773);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4774);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4775);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4776);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4777);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4778);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4779);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4780);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4781);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4782);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4783);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4784);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4785);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4786);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4787);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4788);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4789);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4790);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4791);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4792);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4793);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4794);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4795);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4796);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4797);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4798);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4799);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4800);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4801);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4802);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4803);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4804);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4805);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4806);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4807);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4808);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4809);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4810);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4811);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4812);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4813);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4814);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4815);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4816);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4817);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4818);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4819);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4820);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4821);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4822);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4823);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4824);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4825);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4826);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4827);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4828);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4829);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4830);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4831);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4832);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4833);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4834);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4835);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4836);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4837);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4838);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4839);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4840);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4841);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4842);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4843);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4844);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4845);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4846);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4847);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4848);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4849);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4850);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4851);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4852);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4853);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4854);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4855);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4856);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4857);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4858);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4859);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4860);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4861);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4862);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4863);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4864);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4865);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4866);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4867);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4868);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4869);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4870);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4871);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4872);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4873);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4874);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4875);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4876);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4877);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4878);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4879);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4880);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4881);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4882);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4883);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4884);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4885);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4886);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4887);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4888);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4889);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4890);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4891);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4892);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4893);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4894);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4895);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4896);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4897);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4898);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4899);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4900);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4901);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4902);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4903);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4904);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4905);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4906);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4907);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4908);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4909);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4910);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4911);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4912);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4913);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4914);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4915);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4916);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4917);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4918);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4919);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4920);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4921);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4922);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4923);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4924);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4925);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4926);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4927);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4928);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4929);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4930);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4931);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4932);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4933);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4934);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4935);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4936);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4937);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4938);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4939);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4940);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4941);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4942);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4943);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4944);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4945);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4946);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4947);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4948);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4949);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4950);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4951);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4952);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4953);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4954);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4955);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4956);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4957);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4958);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4959);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4960);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4961);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4962);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4963);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4964);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4965);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4966);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4967);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4968);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4969);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4970);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4971);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4972);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4973);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4974);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4975);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4976);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4977);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4978);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4979);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4980);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4981);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4982);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4983);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4984);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4985);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4986);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4987);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4988);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4989);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4990);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4991);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4992);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4993);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4994);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4995);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4996);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4997);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4998);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 4999);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5000);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5001);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5002);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5003);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5004);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5005);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5006);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5007);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5008);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5009);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5010);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5011);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5012);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5013);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5014);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5015);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5016);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5017);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5018);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5019);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5020);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5021);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5022);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5023);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5024);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5025);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5026);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5027);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5028);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5029);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5030);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5031);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5032);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5033);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5034);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5035);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5036);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5037);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5038);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5039);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5040);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5041);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5042);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5043);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5044);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5045);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5046);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5047);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5048);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5049);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5050);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5051);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5052);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5053);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5054);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5055);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5056);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5057);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5058);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5059);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5060);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5061);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5062);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5063);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5064);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5065);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5066);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5067);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5068);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5069);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5070);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5071);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5072);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5073);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5074);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5075);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5076);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5077);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5078);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5079);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5080);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5081);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5082);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5083);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5084);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5085);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5086);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5087);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5088);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5089);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5090);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5091);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5092);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5093);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5094);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5095);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5096);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5097);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5098);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5099);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5100);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5101);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5102);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5103);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5104);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5105);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5106);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5107);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5108);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5109);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5110);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5111);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5112);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5113);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5114);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5115);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5116);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5117);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5118);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5119);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5120);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5121);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5122);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5123);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5124);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5125);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5126);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5127);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5128);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5129);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5130);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5131);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5132);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5133);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5134);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5135);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5136);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5137);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5138);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5139);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5140);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5141);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5142);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5143);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5144);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5145);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5146);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5147);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5148);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5149);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5150);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5151);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5152);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5153);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5154);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5155);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5156);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5157);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5158);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5159);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5160);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5161);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5162);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5163);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5164);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5165);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5166);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5167);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5168);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5169);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5170);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5171);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5172);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5173);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5174);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5175);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5176);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5177);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5178);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5179);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5180);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5181);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5182);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5183);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5184);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5185);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5186);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5187);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5188);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5189);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5190);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5191);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5192);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5193);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5194);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5195);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5196);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5197);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5198);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5199);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5200);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5201);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5202);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5203);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5204);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5205);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5206);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5207);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5208);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5209);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5210);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5211);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5212);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5213);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5214);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5215);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5216);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5217);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5218);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5219);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5220);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5221);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5222);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5223);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5224);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5225);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5226);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5227);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5228);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5229);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5230);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5231);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5232);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5233);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5234);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5235);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5236);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5237);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5238);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5239);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5240);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5241);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5242);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5243);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5244);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5245);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5246);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5247);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5248);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5249);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5250);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5251);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5252);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5253);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5254);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5255);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5256);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5257);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5258);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5259);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5260);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5261);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5262);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5263);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5264);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5265);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5266);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5267);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5268);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5269);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5270);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5271);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5272);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5273);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5274);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5275);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5276);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5277);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5278);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5279);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5280);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5281);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5282);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5283);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5284);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5285);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5286);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5287);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5288);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5289);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5290);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5291);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5292);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5293);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5294);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5295);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5296);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5297);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5298);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5299);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5300);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5301);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5302);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5303);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5304);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5305);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5306);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5307);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5308);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5309);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5310);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5311);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5312);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5313);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5314);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5315);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5316);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5317);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5318);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5319);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5320);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5321);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5322);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5323);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5324);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5325);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5326);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5327);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5328);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5329);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5330);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5331);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5332);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5333);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5334);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5335);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5336);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5337);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5338);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5339);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5340);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5341);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5342);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5343);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5344);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5345);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5346);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5347);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5348);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5349);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5350);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5351);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5352);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5353);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5354);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5355);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5356);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5357);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5358);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5359);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5360);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5361);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5362);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5363);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5364);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5365);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5366);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5367);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5368);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5369);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5370);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5371);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5372);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5373);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5374);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5375);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5376);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5377);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5378);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5379);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5380);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5381);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5382);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5383);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5384);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5385);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5386);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5387);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5388);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5389);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5390);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5391);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5392);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5393);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5394);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5395);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5396);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5397);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5398);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5399);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5400);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5401);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5402);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5403);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5404);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5405);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5406);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5407);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5408);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5409);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5410);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5411);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5412);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5413);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5414);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5415);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5416);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5417);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5418);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5419);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5420);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5421);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5422);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5423);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5424);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5425);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5426);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5427);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5428);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5429);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5430);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5431);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5432);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5433);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5434);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5435);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5436);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5437);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5438);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5439);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5440);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5441);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5442);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5443);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5444);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5445);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5446);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5447);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5448);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5449);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5450);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5451);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5452);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5453);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5454);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5455);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5456);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5457);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5458);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5459);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5460);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5461);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5462);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5463);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5464);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5465);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5466);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5467);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5468);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5469);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5470);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5471);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5472);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5473);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5474);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5475);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5476);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5477);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5478);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5479);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5480);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5481);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5482);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5483);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5484);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5485);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5486);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5487);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5488);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5489);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5490);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5491);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5492);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5493);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5494);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5495);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5496);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5497);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5498);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5499);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5500);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5501);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5502);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5503);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5504);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5505);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5506);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5507);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5508);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5509);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5510);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5511);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5512);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5513);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5514);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5515);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5516);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5517);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5518);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5519);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5520);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5521);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5522);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5523);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5524);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5525);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5526);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5527);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5528);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5529);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5530);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5531);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5532);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5533);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5534);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5535);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5536);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5537);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5538);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5539);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5540);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5541);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5542);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5543);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5544);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5545);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5546);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5547);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5548);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5549);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5550);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5551);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5552);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5553);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5554);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5555);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5556);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5557);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5558);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5559);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5560);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5561);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5562);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5563);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5564);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5565);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5566);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5567);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5568);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5569);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5570);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5571);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5572);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5573);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5574);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5575);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5576);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5577);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5578);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5579);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5580);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5581);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5582);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5583);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5584);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5585);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5586);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5587);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5588);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5589);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5590);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5591);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5592);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5593);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5594);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5595);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5596);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5597);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5598);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5599);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5600);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5601);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5602);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5603);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5604);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5605);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5606);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5607);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5608);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5609);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5610);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5611);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5612);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5613);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5614);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5615);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5616);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5617);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5618);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5619);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5620);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5621);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5622);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5623);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5624);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5625);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5626);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5627);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5628);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5629);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5630);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5631);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5632);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5633);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5634);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5635);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5636);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5637);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5638);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5639);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5640);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5641);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5642);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5643);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5644);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5645);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5646);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5647);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5648);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5649);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5650);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5651);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5652);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5653);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5654);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5655);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5656);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5657);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5658);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5659);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5660);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5661);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5662);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5663);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5664);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5665);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5666);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5667);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5668);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5669);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5670);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5671);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5672);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5673);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5674);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5675);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5676);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5677);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5678);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5679);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5680);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5681);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5682);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5683);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5684);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5685);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5686);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5687);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5688);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5689);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5690);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5691);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5692);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5693);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5694);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5695);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5696);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5697);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5698);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5699);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5700);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5701);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5702);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5703);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5704);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5705);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5706);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5707);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5708);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5709);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5710);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5711);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5712);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5713);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5714);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5715);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5716);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5717);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5718);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5719);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5720);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5721);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5722);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5723);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5724);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5725);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5726);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5727);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5728);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5729);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5730);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5731);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5732);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5733);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5734);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5735);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5736);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5737);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5738);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5739);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5740);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5741);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5742);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5743);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5744);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5745);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5746);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5747);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5748);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5749);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5750);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5751);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5752);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5753);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5754);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5755);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5756);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5757);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5758);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5759);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5760);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5761);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5762);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5763);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5764);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5765);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5766);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5767);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5768);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5769);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5770);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5771);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5772);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5773);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5774);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5775);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5776);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5777);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5778);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5779);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5780);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5781);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5782);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5783);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5784);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5785);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5786);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5787);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5788);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5789);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5790);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5791);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5792);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5793);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5794);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5795);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5796);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5797);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5798);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5799);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5800);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5801);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5802);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5803);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5804);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5805);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5806);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5807);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5808);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5809);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5810);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5811);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5812);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5813);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5814);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5815);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5816);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5817);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5818);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5819);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5820);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5821);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5822);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5823);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5824);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5825);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5826);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5827);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5828);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5829);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5830);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5831);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5832);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5833);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5834);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5835);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5836);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5837);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5838);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5839);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5840);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5841);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5842);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5843);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5844);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5845);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5846);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5847);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5848);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5849);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5850);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5851);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5852);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5853);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5854);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5855);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5856);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5857);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5858);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5859);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5860);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5861);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5862);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5863);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5864);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5865);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5866);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5867);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5868);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5869);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5870);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5871);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5872);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5873);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5874);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5875);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5876);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5877);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5878);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5879);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5880);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5881);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5882);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5883);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5884);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5885);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5886);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5887);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5888);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5889);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5890);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5891);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5892);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5893);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5894);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5895);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5896);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5897);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5898);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5899);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5900);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5901);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5902);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5903);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5904);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5905);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5906);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5907);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5908);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5909);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5910);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5911);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5912);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5913);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5914);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5915);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5916);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5917);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5918);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5919);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5920);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5921);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5922);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5923);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5924);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5925);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5926);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5927);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5928);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5929);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5930);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5931);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5932);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5933);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5934);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5935);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5936);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5937);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5938);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5939);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5940);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5941);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5942);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5943);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5944);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5945);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5946);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5947);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5948);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5949);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5950);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5951);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5952);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5953);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5954);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5955);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5956);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5957);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5958);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5959);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5960);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5961);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5962);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5963);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5964);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5965);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5966);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5967);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5968);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5969);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5970);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5971);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5972);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5973);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5974);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5975);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5976);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5977);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5978);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5979);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5980);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5981);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5982);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5983);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5984);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5985);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5986);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5987);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5988);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5989);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5990);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5991);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5992);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5993);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5994);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5995);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5996);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5997);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5998);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 5999);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6000);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6001);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6002);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6003);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6004);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6005);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6006);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6007);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6008);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6009);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6010);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6011);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6012);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6013);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6014);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6015);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6016);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6017);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6018);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6019);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6020);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6021);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6022);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6023);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6024);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6025);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6026);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6027);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6028);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6029);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6030);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6031);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6032);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6033);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6034);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6035);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6036);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6037);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6038);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6039);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6040);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6041);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6042);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6043);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6044);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6045);
            migrationBuilder.DeleteData(
                            table: "ReferenceDataItems",
                            keyColumn: "ID",
                            keyValue: 6046);

        }
    }
}
