using Lab2_1;

ExcelentPupil pupil1_ex = new ExcelentPupil();
GoodPupil pupil2_good = new GoodPupil();
GoodPupil pupil3_good = new GoodPupil();
BadPupil pupil4_bad = new BadPupil();

ClassRoom classroom1 = new ClassRoom(pupil1_ex, pupil2_good, pupil3_good, pupil4_bad);
ClassRoom classroom2 = new ClassRoom(pupil1_ex, pupil2_good, pupil4_bad);

classroom1.print_all_pupils_on_class();
classroom2.print_all_pupils_on_class();
