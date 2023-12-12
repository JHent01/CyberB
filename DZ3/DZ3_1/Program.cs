using DZ3_1;

//ClassRoom classRoom = new ClassRoom(new Pupil(), new Pupil(), new Pupil(), new Pupil());
//Console.WriteLine(classRoom);
//Console.WriteLine(classRoom.ToString);
//ExcelentPupil excelentPupil = new ExcelentPupil();
//GoodPupil good = new GoodPupil();
//BadPupil bad = new BadPupil();
//excelentPupil.Relax();
//good.Study();
//bad.Read();
//excelentPupil.Write();
//Console.WriteLine(classRoom.ToString);

ClassRoom cRoom = new ClassRoom(new ExcelentPupil(), new GoodPupil(), new BadPupil(), new GoodPupil());

cRoom.PrintInfoRead();
cRoom.PrintInfoRelax();
cRoom.PrintInfoStudy();
cRoom.PrintInfoWrite();

Console.ReadKey();
