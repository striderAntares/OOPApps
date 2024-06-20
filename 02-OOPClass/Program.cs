using _02_OOPClass;

Personnel newPersonnel = new Personnel();
newPersonnel.Name = "Huseyin";
newPersonnel.Surname = "Talo";
newPersonnel.Title = "Specialist";
newPersonnel.Wage = 60000;
newPersonnel.IDNo = 1;

Console.WriteLine(
                    "Personnel Information: "
                    + "\n------------------\n"
                    + "\n Personnel Name: " +newPersonnel.Name
                    + "\n Personnel Surname: " +newPersonnel.Surname
                    + "\n Personnel Title: " + newPersonnel.Title
                    + "\n Personnel Wage: " + newPersonnel.Wage);
