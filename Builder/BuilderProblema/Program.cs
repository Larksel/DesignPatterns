using BuilderProblema.PDF;

// Builder A4 e seu Director
BuilderA4 builderA4 = new();
GeradorPDFDirector director = new(builderA4);

// Cria um GeradorPDF básico
director.CriarGeradorPDF();
GeradorPDF pdfA4 = builderA4.GetGeradorPDF();

Console.WriteLine(pdfA4.ToString());

// Builder A3 e seu Director
BuilderA3 builderA3 = new();
GeradorPDFDirector director2 = new(builderA3);

// Cria GeradorPDF sem Header e Footer
director2.CriarGeradorPDFNoHeaderNoFooter();
GeradorPDF pdfA3 = builderA3.GetGeradorPDF();

Console.WriteLine(pdfA3.ToString());