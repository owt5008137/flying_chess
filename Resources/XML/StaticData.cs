﻿
namespace OverCraft.Data.XML {
	public static class StaticData {
		public static string XMLHead =
@"<?xml version='1.0' encoding='UTF-8'?>
<Root>
 <Grids>
  <Grid Class='Grid' ID='000' Color='0' X='2' Y='5'>
  <Prev ID='303'></Prev>
  <Next ID='110'></Next>
  <Jump ID='001'></Jump>
  </Grid>
  <Grid Class='Grid' ID='001' Color='0' X='5' Y='3'>
  <Prev ID='304'></Prev>
  <Next ID='111'></Next>
  <Jump ID='002'></Jump>
  </Grid>
  <Grid Class='Grid' ID='002' Color='0' X='7' Y='1'>
  <Prev ID='305'></Prev>
  <Next ID='112'></Next>
  <Jump ID='003'></Jump>
  </Grid>
  <Grid Class='FlyingGrid' ID='003' Color='0' X='11' Y='1'>
  <Prev ID='306'></Prev>
  <Next ID='100'></Next>
  <Jump ID='007'></Jump>
  <Cross ID='215'></Cross>
  </Grid>
  <Grid Class='FlyingGrid' ID='004' Color='0' X='12' Y='5'>
  <Prev ID='307'></Prev>
  <Next ID='101'></Next>
  <Jump ID='008'></Jump>
  <Cross ID='215'></Cross>
  </Grid>
  <Grid Class='Grid' ID='005' Color='0' X='15' Y='6'>
  <Prev ID='308'></Prev>
  <Next ID='102'></Next>
  <Jump ID='006'></Jump>
  </Grid>
  <Grid Class='Grid' ID='006' Color='0' X='15' Y='10'>
  <Prev ID='309'></Prev>
  <Next ID='103'></Next>
  <Jump ID='007'></Jump>
  </Grid>
  <Grid Class='Grid' ID='007' Color='0' X='12' Y='11'>
  <Prev ID='310'></Prev>
  <Next ID='104'></Next>
  <Jump ID='008'></Jump>
  </Grid>
  <Grid Class='Grid' ID='008' Color='0' X='11' Y='15'>
  <Prev ID='311'></Prev>
  <Next ID='105'></Next>
  <Jump ID='009'></Jump>
  </Grid>
  <Grid Class='Grid' ID='009' Color='0' X='7' Y='15'>
  <Prev ID='312'></Prev>
  <Next ID='106'></Next>
  <Jump ID='010'></Jump>
  </Grid>
  <Grid Class='Grid' ID='010' Color='0' X='5' Y='13'>
  <Prev ID='300'></Prev>
  <Next ID='107'></Next>
  <Jump ID='011'></Jump>
  </Grid>
  <Grid Class='Grid' ID='011' Color='0' X='2' Y='11'>
  <Prev ID='301'></Prev>
  <Next ID='108'></Next>
  <Jump ID='012'></Jump>
  </Grid>
  <Grid Class='AlterGrid' ID='012' Color='0' X='1' Y='8'>
  <Prev ID='302'></Prev>
  <Next ID='109'></Next>
  <Jump ID='012'></Jump>
  <Straight ID='013'></Straight>
  </Grid>
  <Grid Class='StraightGrid' ID='013' Color='0' X='2' Y='8'>
  <Prev ID='012'></Prev>
  <Next ID='014'></Next>
  <Jump ID='013'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='014' Color='0' X='3' Y='8'>
  <Prev ID='013'></Prev>
  <Next ID='015'></Next>
  <Jump ID='014'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='015' Color='0' X='4' Y='8'>
  <Prev ID='014'></Prev>
  <Next ID='016'></Next>
  <Jump ID='015'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='016' Color='0' X='5' Y='8'>
  <Prev ID='015'></Prev>
  <Next ID='017'></Next>
  <Jump ID='016'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='017' Color='0' X='6' Y='8'>
  <Prev ID='016'></Prev>
  <Next ID='018'></Next>
  <Jump ID='017'></Jump>
  </Grid>
  <Grid Class='TargetGrid' ID='018' Color='0' X='7' Y='8'>
  <Prev ID='017'></Prev>
  <Next ID='017'></Next>
  <Jump ID='018'></Jump>
  </Grid>
  <Grid Class='Grid' ID='099' Color='0' X='1' Y='4'>
  <Prev ID='098'></Prev>
  <Next ID='303'></Next>
  <Jump ID='099'></Jump>
  </Grid>
  <Grid Class='Grid' ID='098' Color='0' X='3' Y='3'>
  <Prev ID='098'></Prev>
  <Next ID='099'></Next>
  <Jump ID='098'></Jump>
  </Grid>
  <Grid Class='Grid' ID='097' Color='0' X='2' Y='3'>
  <Prev ID='097'></Prev>
  <Next ID='099'></Next>
  <Jump ID='097'></Jump>
  </Grid>
  <Grid Class='Grid' ID='096' Color='0' X='3' Y='2'>
  <Prev ID='096'></Prev>
  <Next ID='099'></Next>
  <Jump ID='096'></Jump>
  </Grid>
  <Grid Class='Grid' ID='095' Color='0' X='2' Y='2'>
  <Prev ID='095'></Prev>
  <Next ID='099'></Next>
  <Jump ID='095'></Jump>
  </Grid>
  <Grid Class='Grid' ID='100' Color='1' X='11' Y='2'>
  <Prev ID='003'></Prev>
  <Next ID='210'></Next>
  <Jump ID='101'></Jump>
  </Grid>
  <Grid Class='Grid' ID='101' Color='1' X='13' Y='5'>
  <Prev ID='004'></Prev>
  <Next ID='211'></Next>
  <Jump ID='102'></Jump>
  </Grid>
  <Grid Class='Grid' ID='102' Color='1' X='15' Y='7'>
  <Prev ID='005'></Prev>
  <Next ID='212'></Next>
  <Jump ID='103'></Jump>
  </Grid>
  <Grid Class='FlyingGrid' ID='103' Color='1' X='15' Y='11'>
  <Prev ID='006'></Prev>
  <Next ID='200'></Next>
  <Jump ID='107'></Jump>
  <Cross ID='315'></Cross>
  </Grid>
  <Grid Class='FlyingGrid' ID='104' Color='1' X='11' Y='12'>
  <Prev ID='007'></Prev>
  <Next ID='201'></Next>
  <Jump ID='108'></Jump>
  <Cross ID='315'></Cross>
  </Grid>
  <Grid Class='Grid' ID='105' Color='1' X='10' Y='15'>
  <Prev ID='008'></Prev>
  <Next ID='202'></Next>
  <Jump ID='106'></Jump>
  </Grid>
  <Grid Class='Grid' ID='106' Color='1' X='6' Y='15'>
  <Prev ID='009'></Prev>
  <Next ID='203'></Next>
  <Jump ID='107'></Jump>
  </Grid>
  <Grid Class='Grid' ID='107' Color='1' X='5' Y='12'>
  <Prev ID='010'></Prev>
  <Next ID='204'></Next>
  <Jump ID='108'></Jump>
  </Grid>
  <Grid Class='Grid' ID='108' Color='1' X='1' Y='11'>
  <Prev ID='011'></Prev>
  <Next ID='205'></Next>
  <Jump ID='109'></Jump>
  </Grid>
  <Grid Class='Grid' ID='109' Color='1' X='1' Y='7'>
  <Prev ID='012'></Prev>
  <Next ID='206'></Next>
  <Jump ID='110'></Jump>
  </Grid>
  <Grid Class='Grid' ID='110' Color='1' X='3' Y='5'>
  <Prev ID='000'></Prev>
  <Next ID='207'></Next>
  <Jump ID='111'></Jump>
  </Grid>
  <Grid Class='Grid' ID='111' Color='1' X='5' Y='2'>
  <Prev ID='001'></Prev>
  <Next ID='208'></Next>
  <Jump ID='112'></Jump>
  </Grid>
  <Grid Class='AlterGrid' ID='112' Color='1' X='8' Y='1'>
  <Prev ID='002'></Prev>
  <Next ID='209'></Next>
  <Jump ID='112'></Jump>
  <Straight ID='113'></Straight>
  </Grid>
  <Grid Class='StraightGrid' ID='113' Color='1' X='8' Y='2'>
  <Prev ID='112'></Prev>
  <Next ID='114'></Next>
  <Jump ID='113'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='114' Color='1' X='8' Y='3'>
  <Prev ID='113'></Prev>
  <Next ID='115'></Next>
  <Jump ID='114'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='115' Color='1' X='8' Y='4'>
  <Prev ID='114'></Prev>
  <Next ID='116'></Next>
  <Jump ID='115'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='116' Color='1' X='8' Y='5'>
  <Prev ID='115'></Prev>
  <Next ID='117'></Next>
  <Jump ID='116'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='117' Color='1' X='8' Y='6'>
  <Prev ID='116'></Prev>
  <Next ID='118'></Next>
  <Jump ID='117'></Jump>
  </Grid>
  <Grid Class='TargetGrid' ID='118' Color='1' X='8' Y='7'>
  <Prev ID='117'></Prev>
  <Next ID='117'></Next>
  <Jump ID='118'></Jump>
  </Grid>
  <Grid Class='Grid' ID='199' Color='1' X='12' Y='1'>
  <Prev ID='198'></Prev>
  <Next ID='003'></Next>
  <Jump ID='199'></Jump>
  </Grid>
  <Grid Class='Grid' ID='198' Color='1' X='13' Y='3'>
  <Prev ID='198'></Prev>
  <Next ID='199'></Next>
  <Jump ID='198'></Jump>
  </Grid>
  <Grid Class='Grid' ID='197' Color='1' X='13' Y='2'>
  <Prev ID='197'></Prev>
  <Next ID='199'></Next>
  <Jump ID='197'></Jump>
  </Grid>
  <Grid Class='Grid' ID='196' Color='1' X='14' Y='3'>
  <Prev ID='196'></Prev>
  <Next ID='199'></Next>
  <Jump ID='196'></Jump>
  </Grid>
  <Grid Class='Grid' ID='195' Color='1' X='14' Y='2'>
  <Prev ID='195'></Prev>
  <Next ID='199'></Next>
  <Jump ID='195'></Jump>
  </Grid>
  <Grid Class='Grid' ID='200' Color='2' X='14' Y='11'>
  <Prev ID='103'></Prev>
  <Next ID='310'></Next>
  <Jump ID='201'></Jump>
  </Grid>
  <Grid Class='Grid' ID='201' Color='2' X='11' Y='13'>
  <Prev ID='104'></Prev>
  <Next ID='311'></Next>
  <Jump ID='202'></Jump>
  </Grid>
  <Grid Class='Grid' ID='202' Color='2' X='9' Y='15'>
  <Prev ID='105'></Prev>
  <Next ID='312'></Next>
  <Jump ID='203'></Jump>
  </Grid>
  <Grid Class='FlyingGrid' ID='203' Color='2' X='5' Y='15'>
  <Prev ID='106'></Prev>
  <Next ID='300'></Next>
  <Jump ID='207'></Jump>
  <Cross ID='015'></Cross>
  </Grid>
  <Grid Class='FlyingGrid' ID='204' Color='2' X='4' Y='11'>
  <Prev ID='107'></Prev>
  <Next ID='301'></Next>
  <Jump ID='208'></Jump>
  <Cross ID='015'></Cross>
  </Grid>
  <Grid Class='Grid' ID='205' Color='2' X='1' Y='10'>
  <Prev ID='108'></Prev>
  <Next ID='302'></Next>
  <Jump ID='206'></Jump>
  </Grid>
  <Grid Class='Grid' ID='206' Color='2' X='1' Y='6'>
  <Prev ID='109'></Prev>
  <Next ID='303'></Next>
  <Jump ID='207'></Jump>
  </Grid>
  <Grid Class='Grid' ID='207' Color='2' X='4' Y='5'>
  <Prev ID='110'></Prev>
  <Next ID='304'></Next>
  <Jump ID='208'></Jump>
  </Grid>
  <Grid Class='Grid' ID='208' Color='2' X='5' Y='1'>
  <Prev ID='111'></Prev>
  <Next ID='305'></Next>
  <Jump ID='209'></Jump>
  </Grid>
  <Grid Class='Grid' ID='209' Color='2' X='9' Y='1'>
  <Prev ID='112'></Prev>
  <Next ID='306'></Next>
  <Jump ID='210'></Jump>
  </Grid>
  <Grid Class='Grid' ID='210' Color='2' X='11' Y='3'>
  <Prev ID='100'></Prev>
  <Next ID='307'></Next>
  <Jump ID='211'></Jump>
  </Grid>
  <Grid Class='Grid' ID='211' Color='2' X='14' Y='5'>
  <Prev ID='101'></Prev>
  <Next ID='308'></Next>
  <Jump ID='212'></Jump>
  </Grid>
  <Grid Class='AlterGrid' ID='212' Color='2' X='15' Y='8'>
  <Prev ID='102'></Prev>
  <Next ID='309'></Next>
  <Jump ID='212'></Jump>
  <Straight ID='213'></Straight>
  </Grid>
  <Grid Class='StraightGrid' ID='213' Color='2' X='14' Y='8'>
  <Prev ID='212'></Prev>
  <Next ID='214'></Next>
  <Jump ID='213'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='214' Color='2' X='13' Y='8'>
  <Prev ID='213'></Prev>
  <Next ID='215'></Next>
  <Jump ID='214'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='215' Color='2' X='12' Y='8'>
  <Prev ID='214'></Prev>
  <Next ID='216'></Next>
  <Jump ID='215'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='216' Color='2' X='11' Y='8'>
  <Prev ID='215'></Prev>
  <Next ID='217'></Next>
  <Jump ID='216'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='217' Color='2' X='10' Y='8'>
  <Prev ID='216'></Prev>
  <Next ID='218'></Next>
  <Jump ID='217'></Jump>
  </Grid>
  <Grid Class='TargetGrid' ID='218' Color='2' X='9' Y='8'>
  <Prev ID='217'></Prev>
  <Next ID='217'></Next>
  <Jump ID='218'></Jump>
  </Grid>
  <Grid Class='Grid' ID='299' Color='2' X='15' Y='12'>
  <Prev ID='298'></Prev>
  <Next ID='103'></Next>
  <Jump ID='299'></Jump>
  </Grid>
  <Grid Class='Grid' ID='298' Color='2' X='13' Y='13'>
  <Prev ID='298'></Prev>
  <Next ID='299'></Next>
  <Jump ID='298'></Jump>
  </Grid>
  <Grid Class='Grid' ID='297' Color='2' X='14' Y='13'>
  <Prev ID='297'></Prev>
  <Next ID='299'></Next>
  <Jump ID='297'></Jump>
  </Grid>
  <Grid Class='Grid' ID='296' Color='2' X='13' Y='14'>
  <Prev ID='296'></Prev>
  <Next ID='299'></Next>
  <Jump ID='296'></Jump>
  </Grid>
  <Grid Class='Grid' ID='295' Color='2' X='14' Y='14'>
  <Prev ID='295'></Prev>
  <Next ID='299'></Next>
  <Jump ID='295'></Jump>
  </Grid>
  <Grid Class='Grid' ID='300' Color='3' X='5' Y='14'>
  <Prev ID='203'></Prev>
  <Next ID='010'></Next>
  <Jump ID='301'></Jump>
  </Grid>
  <Grid Class='Grid' ID='301' Color='3' X='3' Y='11'>
  <Prev ID='204'></Prev>
  <Next ID='011'></Next>
  <Jump ID='302'></Jump>
  </Grid>
  <Grid Class='Grid' ID='302' Color='3' X='1' Y='9'>
  <Prev ID='205'></Prev>
  <Next ID='012'></Next>
  <Jump ID='303'></Jump>
  </Grid>
  <Grid Class='FlyingGrid' ID='303' Color='3' X='1' Y='5'>
  <Prev ID='206'></Prev>
  <Next ID='000'></Next>
  <Jump ID='307'></Jump>
  <Cross ID='115'></Cross>
  </Grid>
  <Grid Class='FlyingGrid' ID='304' Color='3' X='5' Y='4'>
  <Prev ID='207'></Prev>
  <Next ID='001'></Next>
  <Jump ID='308'></Jump>
  <Cross ID='115'></Cross>
  </Grid>
  <Grid Class='Grid' ID='305' Color='3' X='6' Y='1'>
  <Prev ID='208'></Prev>
  <Next ID='002'></Next>
  <Jump ID='306'></Jump>
  </Grid>
  <Grid Class='Grid' ID='306' Color='3' X='10' Y='1'>
  <Prev ID='209'></Prev>
  <Next ID='003'></Next>
  <Jump ID='307'></Jump>
  </Grid>
  <Grid Class='Grid' ID='307' Color='3' X='11' Y='4'>
  <Prev ID='210'></Prev>
  <Next ID='004'></Next>
  <Jump ID='308'></Jump>
  </Grid>
  <Grid Class='Grid' ID='308' Color='3' X='15' Y='5'>
  <Prev ID='211'></Prev>
  <Next ID='005'></Next>
  <Jump ID='309'></Jump>
  </Grid>
  <Grid Class='Grid' ID='309' Color='3' X='15' Y='9'>
  <Prev ID='212'></Prev>
  <Next ID='006'></Next>
  <Jump ID='310'></Jump>
  </Grid>
  <Grid Class='Grid' ID='310' Color='3' X='13' Y='11'>
  <Prev ID='200'></Prev>
  <Next ID='007'></Next>
  <Jump ID='311'></Jump>
  </Grid>
  <Grid Class='Grid' ID='311' Color='3' X='11' Y='14'>
  <Prev ID='201'></Prev>
  <Next ID='008'></Next>
  <Jump ID='312'></Jump>
  </Grid>
  <Grid Class='AlterGrid' ID='312' Color='3' X='8' Y='15'>
  <Prev ID='202'></Prev>
  <Next ID='009'></Next>
  <Jump ID='312'></Jump>
  <Straight ID='313'></Straight>
  </Grid>
  <Grid Class='StraightGrid' ID='313' Color='3' X='8' Y='14'>
  <Prev ID='312'></Prev>
  <Next ID='314'></Next>
  <Jump ID='313'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='314' Color='3' X='8' Y='13'>
  <Prev ID='313'></Prev>
  <Next ID='315'></Next>
  <Jump ID='314'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='315' Color='3' X='8' Y='12'>
  <Prev ID='314'></Prev>
  <Next ID='316'></Next>
  <Jump ID='315'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='316' Color='3' X='8' Y='11'>
  <Prev ID='315'></Prev>
  <Next ID='317'></Next>
  <Jump ID='316'></Jump>
  </Grid>
  <Grid Class='StraightGrid' ID='317' Color='3' X='8' Y='10'>
  <Prev ID='316'></Prev>
  <Next ID='318'></Next>
  <Jump ID='317'></Jump>
  </Grid>
  <Grid Class='TargetGrid' ID='318' Color='3' X='8' Y='9'>
  <Prev ID='317'></Prev>
  <Next ID='317'></Next>
  <Jump ID='318'></Jump>
  </Grid>
  <Grid Class='Grid' ID='399' Color='3' X='4' Y='15'>
  <Prev ID='398'></Prev>
  <Next ID='203'></Next>
  <Jump ID='399'></Jump>
  </Grid>
  <Grid Class='Grid' ID='398' Color='3' X='3' Y='13'>
  <Prev ID='398'></Prev>
  <Next ID='399'></Next>
  <Jump ID='398'></Jump>
  </Grid>
  <Grid Class='Grid' ID='397' Color='3' X='3' Y='14'>
  <Prev ID='397'></Prev>
  <Next ID='399'></Next>
  <Jump ID='397'></Jump>
  </Grid>
  <Grid Class='Grid' ID='396' Color='3' X='2' Y='13'>
  <Prev ID='396'></Prev>
  <Next ID='399'></Next>
  <Jump ID='396'></Jump>
  </Grid>
  <Grid Class='Grid' ID='395' Color='3' X='2' Y='14'>
  <Prev ID='395'></Prev>
  <Next ID='399'></Next>
  <Jump ID='395'></Jump>
  </Grid>
 </Grids>
";

		public static string[] XMLPlayers = {
		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  <Plane Grid='097'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  <Plane Grid='297'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  <Plane Grid='097'>
  </Plane>
  <Plane Grid='098'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  <Plane Grid='297'>
  </Plane>
  <Plane Grid='298'>
  </Plane>
  </Player>
 </Players>
", 
		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  </Player>
  <Player Color='1'>
  <Plane Grid='195'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  </Player>
  <Player Color='3'>
  <Plane Grid='395'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  </Player>
  <Player Color='1'>
  <Plane Grid='195'>
  </Plane>
  <Plane Grid='196'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  </Player>
  <Player Color='3'>
  <Plane Grid='395'>
  </Plane>
  <Plane Grid='396'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  <Plane Grid='097'>
  </Plane>
  </Player>
  <Player Color='1'>
  <Plane Grid='195'>
  </Plane>
  <Plane Grid='196'>
  </Plane>
  <Plane Grid='197'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  <Plane Grid='297'>
  </Plane>
  </Player>
  <Player Color='3'>
  <Plane Grid='395'>
  </Plane>
  <Plane Grid='396'>
  </Plane>
  <Plane Grid='397'>
  </Plane>
  </Player>
 </Players>
", 		@"
 <Players>
  <Player Color='0'>
  <Plane Grid='095'>
  </Plane>
  <Plane Grid='096'>
  </Plane>
  <Plane Grid='097'>
  </Plane>
  <Plane Grid='098'>
  </Plane>
  </Player>
  <Player Color='1'>
  <Plane Grid='195'>
  </Plane>
  <Plane Grid='196'>
  </Plane>
  <Plane Grid='197'>
  </Plane>
  <Plane Grid='198'>
  </Plane>
  </Player>
  <Player Color='2'>
  <Plane Grid='295'>
  </Plane>
  <Plane Grid='296'>
  </Plane>
  <Plane Grid='297'>
  </Plane>
  <Plane Grid='298'>
  </Plane>
  </Player>
  <Player Color='3'>
  <Plane Grid='395'>
  </Plane>
  <Plane Grid='396'>
  </Plane>
  <Plane Grid='397'>
  </Plane>
  <Plane Grid='398'>
  </Plane>
  </Player>
 </Players>
", 
		};

		public static string XMLFoot = "</Root>";
	}
}
