namespace DlinkDFE.Web.MockData
{
    public static class DocumentosMockData
    {
        public static List<Documento> GetDocumentosAsync()
        {
            return new List<Documento>
            {
                new Documento { Id = 1, Status = "Autorizado", Modelo = 55, Numero = "123456", Serie = "1", Emissao = DateTime.Now.AddDays(-1), Destinatario = "Empresa A", Valor = 1000.00m },
                new Documento { Id = 2, Status = "Pendente", Modelo = 65, Numero = "123457", Serie = "2", Emissao = DateTime.Now.AddDays(-21), Destinatario = "Empresa B", Valor = 1500.00m },
                new Documento { Id = 3, Status = "Autorizado", Modelo = 55, Numero = "123458", Serie = "3", Emissao = DateTime.Now.AddDays(-2), Destinatario = "Empresa C", Valor = 2000.00m },
                new Documento { Id = 4, Status = "Rejeitado", Modelo = 65, Numero = "123459", Serie = "4", Emissao = DateTime.Now.AddDays(-3), Destinatario = "Empresa D", Valor = 2500.00m },
                new Documento { Id = 5, Status = "Autorizado", Modelo = 55, Numero = "123460", Serie = "5", Emissao = DateTime.Now.AddDays(-4), Destinatario = "Empresa E", Valor = 3000.00m },
                new Documento { Id = 6, Status = "Pendente", Modelo = 65, Numero = "123461", Serie = "6", Emissao = DateTime.Now.AddDays(-5), Destinatario = "Empresa F", Valor = 3500.00m },
                new Documento { Id = 7, Status = "Autorizado", Modelo = 55, Numero = "123462", Serie = "7", Emissao = DateTime.Now.AddDays(-6), Destinatario = "Empresa G", Valor = 4000.00m },
                new Documento { Id = 8, Status = "Rejeitado", Modelo = 65, Numero = "123463", Serie = "8", Emissao = DateTime.Now.AddDays(-7), Destinatario = "Empresa H", Valor = 4500.00m },
                new Documento { Id = 9, Status = "Autorizado", Modelo = 55, Numero = "123464", Serie = "9", Emissao = DateTime.Now.AddDays(-8), Destinatario = "Empresa I", Valor = 5000.00m },
                new Documento { Id = 10, Status = "Pendente", Modelo = 65, Numero = "123465", Serie = "10", Emissao = DateTime.Now.AddDays(-9), Destinatario = "Empresa J", Valor = 5500.00m },
                new Documento { Id = 11, Status = "Autorizado", Modelo = 55, Numero = "123466", Serie = "11", Emissao = DateTime.Now.AddDays(-10), Destinatario = "Empresa K", Valor = 6000.00m },
                new Documento { Id = 12, Status = "Rejeitado", Modelo = 65, Numero = "123467", Serie = "12", Emissao = DateTime.Now.AddDays(-11), Destinatario = "Empresa L", Valor = 6500.00m },
                new Documento { Id = 13, Status = "Autorizado", Modelo = 55, Numero = "123468", Serie = "13", Emissao = DateTime.Now.AddDays(-12), Destinatario = "Empresa M", Valor = 7000.00m },
                new Documento { Id = 14, Status = "Pendente", Modelo = 65, Numero = "123469", Serie = "14", Emissao = DateTime.Now.AddDays(-13), Destinatario = "Empresa N", Valor = 7500.00m },
                new Documento { Id = 15, Status = "Autorizado", Modelo = 55, Numero = "123470", Serie = "15", Emissao = DateTime.Now.AddDays(-14), Destinatario = "Empresa O", Valor = 8000.00m },
                new Documento { Id = 16, Status = "Rejeitado", Modelo = 65, Numero = "123471", Serie = "16", Emissao = DateTime.Now.AddDays(-15), Destinatario = "Empresa P", Valor = 8500.00m },
                new Documento { Id = 17, Status = "Autorizado", Modelo = 55, Numero = "123472", Serie = "17", Emissao = DateTime.Now.AddDays(-16), Destinatario = "Empresa Q", Valor = 9000.00m },
                new Documento { Id = 18, Status = "Pendente", Modelo = 65, Numero = "123473", Serie = "18", Emissao = DateTime.Now.AddDays(-17), Destinatario = "Empresa R", Valor = 9500.00m },
                new Documento { Id = 19, Status = "Autorizado", Modelo = 55, Numero = "123474", Serie = "19", Emissao = DateTime.Now.AddDays(-18), Destinatario = "Empresa S", Valor = 10000.00m },
                new Documento { Id = 20, Status = "Rejeitado", Modelo = 65, Numero = "123475", Serie = "20", Emissao = DateTime.Now.AddDays(-19), Destinatario = "Empresa T", Valor = 10500.00m },
                new Documento { Id = 21, Status = "Autorizado", Modelo = 55, Numero = "123476", Serie = "21", Emissao = DateTime.Now.AddDays(-20), Destinatario = "Empresa U", Valor = 11000.00m },
                new Documento { Id = 22, Status = "Pendente", Modelo = 65, Numero = "123477", Serie = "22", Emissao = DateTime.Now.AddDays(-21), Destinatario = "Empresa V", Valor = 11500.00m },
                new Documento { Id = 23, Status = "Autorizado", Modelo = 55, Numero = "123478", Serie = "23", Emissao = DateTime.Now.AddDays(-22), Destinatario = "Empresa W", Valor = 12000.00m },
                new Documento { Id = 24, Status = "Rejeitado", Modelo = 65, Numero = "123479", Serie = "24", Emissao = DateTime.Now.AddDays(-23), Destinatario = "Empresa X", Valor = 12500.00m },
                new Documento { Id = 25, Status = "Autorizado", Modelo = 55, Numero = "123480", Serie = "25", Emissao = DateTime.Now.AddDays(-24), Destinatario = "Empresa Y", Valor = 13000.00m },
                new Documento { Id = 26, Status = "Pendente", Modelo = 65, Numero = "123481", Serie = "26", Emissao = DateTime.Now.AddDays(-25), Destinatario = "Empresa Z", Valor = 13500.00m },
                new Documento { Id = 27, Status = "Autorizado", Modelo = 55, Numero = "123482", Serie = "27", Emissao = DateTime.Now.AddDays(-26), Destinatario = "Empresa AA", Valor = 14000.00m },
                new Documento { Id = 28, Status = "Pendente", Modelo = 65, Numero = "123483", Serie = "28", Emissao = DateTime.Now.AddDays(-27), Destinatario = "Empresa BB", Valor = 14500.00m },
                new Documento { Id = 29, Status = "Autorizado", Modelo = 55, Numero = "123484", Serie = "29", Emissao = DateTime.Now.AddDays(-28), Destinatario = "Empresa CC", Valor = 15000.00m },
                new Documento { Id = 30, Status = "Rejeitado", Modelo = 65, Numero = "123485", Serie = "30", Emissao = DateTime.Now.AddDays(-29), Destinatario = "Empresa DD", Valor = 15500.00m },
                new Documento { Id = 31, Status = "Autorizado", Modelo = 55, Numero = "123486", Serie = "31", Emissao = DateTime.Now.AddDays(-30), Destinatario = "Empresa EE", Valor = 16000.00m },
                new Documento { Id = 32, Status = "Pendente", Modelo = 65, Numero = "123487", Serie = "32", Emissao = DateTime.Now.AddDays(-31), Destinatario = "Empresa FF", Valor = 16500.00m },
                new Documento { Id = 33, Status = "Autorizado", Modelo = 55, Numero = "123488", Serie = "33", Emissao = DateTime.Now.AddDays(-32), Destinatario = "Empresa GG", Valor = 17000.00m },
                new Documento { Id = 34, Status = "Rejeitado", Modelo = 65, Numero = "123489", Serie = "34", Emissao = DateTime.Now.AddDays(-33), Destinatario = "Empresa HH", Valor = 17500.00m },
                new Documento { Id = 35, Status = "Autorizado", Modelo = 55, Numero = "123490", Serie = "35", Emissao = DateTime.Now.AddDays(-34), Destinatario = "Empresa II", Valor = 18000.00m },
                new Documento { Id = 36, Status = "Pendente", Modelo = 65, Numero = "123491", Serie = "36", Emissao = DateTime.Now.AddDays(-35), Destinatario = "Empresa JJ", Valor = 18500.00m },
                new Documento { Id = 37, Status = "Autorizado", Modelo = 55, Numero = "123492", Serie = "37", Emissao = DateTime.Now.AddDays(-36), Destinatario = "Empresa KK", Valor = 19000.00m },
                new Documento { Id = 38, Status = "Rejeitado", Modelo = 65, Numero = "123493", Serie = "38", Emissao = DateTime.Now.AddDays(-37), Destinatario = "Empresa LL", Valor = 19500.00m },
                new Documento { Id = 39, Status = "Autorizado", Modelo = 55, Numero = "123494", Serie = "39", Emissao = DateTime.Now.AddDays(-38), Destinatario = "Empresa MM", Valor = 20000.00m },
                new Documento { Id = 40, Status = "Pendente", Modelo = 65, Numero = "123495", Serie = "40", Emissao = DateTime.Now.AddDays(-39), Destinatario = "Empresa NN", Valor = 20500.00m },
                new Documento { Id = 41, Status = "Autorizado", Modelo = 55, Numero = "123496", Serie = "41", Emissao = DateTime.Now.AddDays(-40), Destinatario = "Empresa OO", Valor = 21000.00m },
                new Documento { Id = 42, Status = "Pendente", Modelo = 65, Numero = "123497", Serie = "42", Emissao = DateTime.Now.AddDays(-41), Destinatario = "Empresa PP", Valor = 21500.00m },
                new Documento { Id = 43, Status = "Autorizado", Modelo = 55, Numero = "123498", Serie = "43", Emissao = DateTime.Now.AddDays(-42), Destinatario = "Empresa QQ", Valor = 22000.00m },
                new Documento { Id = 44, Status = "Rejeitado", Modelo = 65, Numero = "123499", Serie = "44", Emissao = DateTime.Now.AddDays(-43), Destinatario = "Empresa RR", Valor = 22500.00m },
                new Documento { Id = 45, Status = "Autorizado", Modelo = 55, Numero = "123500", Serie = "45", Emissao = DateTime.Now.AddDays(-44), Destinatario = "Empresa SS", Valor = 23000.00m },
                new Documento { Id = 46, Status = "Pendente", Modelo = 65, Numero = "123501", Serie = "46", Emissao = DateTime.Now.AddDays(-45), Destinatario = "Empresa TT", Valor = 23500.00m },
                new Documento { Id = 47, Status = "Autorizado", Modelo = 55, Numero = "123502", Serie = "47", Emissao = DateTime.Now.AddDays(-46), Destinatario = "Empresa UU", Valor = 24000.00m },
                new Documento { Id = 48, Status = "Rejeitado", Modelo = 65, Numero = "123503", Serie = "48", Emissao = DateTime.Now.AddDays(-47), Destinatario = "Empresa VV", Valor = 24500.00m },
                new Documento { Id = 49, Status = "Autorizado", Modelo = 55, Numero = "123504", Serie = "49", Emissao = DateTime.Now.AddDays(-48), Destinatario = "Empresa WW", Valor = 25000.00m },
                new Documento { Id = 50, Status = "Pendente", Modelo = 65, Numero = "123505", Serie = "50", Emissao = DateTime.Now.AddDays(-49), Destinatario = "Empresa XX", Valor = 25500.00m },
                new Documento { Id = 51, Status = "Autorizado", Modelo = 55, Numero = "123506", Serie = "51", Emissao = DateTime.Now.AddDays(-50), Destinatario = "Empresa YY", Valor = 26000.00m },
                new Documento { Id = 52, Status = "Pendente", Modelo = 65, Numero = "123507", Serie = "52", Emissao = DateTime.Now.AddDays(-51), Destinatario = "Empresa ZZ", Valor = 26500.00m },
                new Documento { Id = 53, Status = "Autorizado", Modelo = 55, Numero = "123508", Serie = "53", Emissao = DateTime.Now.AddDays(-52), Destinatario = "Empresa AAA", Valor = 27000.00m },
                new Documento { Id = 54, Status = "Rejeitado", Modelo = 65, Numero = "123509", Serie = "54", Emissao = DateTime.Now.AddDays(-53), Destinatario = "Empresa BBB", Valor = 27500.00m },
                new Documento { Id = 55, Status = "Autorizado", Modelo = 55, Numero = "123510", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 56, Status = "Pendente", Modelo = 65, Numero = "123511", Serie = "56", Emissao = DateTime.Now.AddDays(-55), Destinatario = "Empresa DDD", Valor = 28500.00m },
                new Documento { Id = 57, Status = "Autorizado", Modelo = 55, Numero = "123512", Serie = "57", Emissao = DateTime.Now.AddDays(-56), Destinatario = "Empresa EEE", Valor = 29000.00m },
                new Documento { Id = 58, Status = "Rejeitado", Modelo = 65, Numero = "123513", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 59, Status = "Autorizado", Modelo = 55, Numero = "123514", Serie = "59", Emissao = DateTime.Now.AddDays(-58), Destinatario = "Empresa GGG", Valor = 30000.00m },
                new Documento { Id = 60, Status = "Pendente", Modelo = 65, Numero = "123515", Serie = "60", Emissao = DateTime.Now.AddDays(-59), Destinatario = "Empresa HHH", Valor = 30500.00m },
                new Documento { Id = 61, Status = "Autorizado", Modelo = 55, Numero = "123516", Serie = "61", Emissao = DateTime.Now.AddDays(-60), Destinatario = "Empresa III", Valor = 31000.00m },
                new Documento { Id = 62, Status = "Pendente", Modelo = 65, Numero = "123517", Serie = "62", Emissao = DateTime.Now.AddDays(-61), Destinatario = "Empresa JJJ", Valor = 31500.00m },
                new Documento { Id = 63, Status = "Autorizado", Modelo = 55, Numero = "82376487", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 64, Status = "Autorizado", Modelo = 55, Numero = "4234123", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 65, Status = "Autorizado", Modelo = 55, Numero = "24234234", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 66, Status = "Autorizado", Modelo = 55, Numero = "2432342343", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 67, Status = "Pendente", Modelo = 55, Numero = "12331613465134518", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 68, Status = "Pendente", Modelo = 55, Numero = "12313543513518", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 69, Status = "Autorizado", Modelo = 55, Numero = "423432", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 70, Status = "Autorizado", Modelo = 55, Numero = "235151", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 71, Status = "Autorizado", Modelo = 55, Numero = "24234234", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 72, Status = "Autorizado", Modelo = 55, Numero = "252523", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 73, Status = "Autorizado", Modelo = 55, Numero = "24234234234", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 74, Status = "Pendente",Modelo = 55, Numero = "123515241518", Serie = "63", Emissao = DateTime.Now.AddDays(-62), Destinatario = "Empresa Kkk", Valor = 32000.00m },
                new Documento { Id = 75, Status = "Pendente", Modelo = 55, Numero = "4523523", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 76, Status = "Autorizado", Modelo = 55, Numero = "32523423434", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 77, Status = "Autorizado", Modelo = 55, Numero = "62464365", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 78, Status = "Pendente", Modelo = 55, Numero = "35345345435", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 79, Status = "Autorizado", Modelo = 65, Numero = "646136346", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 80, Status = "Autorizado", Modelo = 55, Numero = "34353543", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 81, Status = "Autorizado", Modelo = 65, Numero = "5345523423", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 82, Status = "Pendente", Modelo = 65, Numero = "462643635", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 83, Status = "Autorizado", Modelo = 55, Numero = "36456436345", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 84, Status = "Autorizado", Modelo = 65, Numero = "6464354235325", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 85, Status = "Pendente", Modelo = 55, Numero = "236346435", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 86, Status = "Autorizado", Modelo = 55, Numero = "6828724575463453", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 87, Status = "Autorizado", Modelo = 65, Numero = "747546345323", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 88, Status = "Autorizado", Modelo = 55, Numero = "6346346747", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 89, Status = "Autorizado", Modelo = 55, Numero = "53663465345", Serie = "55", Emissao = DateTime.Now.AddDays(-54), Destinatario = "Empresa CCC", Valor = 28000.00m },
                new Documento { Id = 90, Status = "Rejeitado", Modelo = 65, Numero = "82473648726", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 91 ,Status = "Rejeitado", Modelo = 65, Numero = "84239847", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 92, Status = "Rejeitado", Modelo = 55, Numero = "9283472374", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 93, Status = "Rejeitado", Modelo = 55, Numero = "2983747293", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 94, Status = "Rejeitado", Modelo = 65, Numero = "897234623", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 95, Status = "Rejeitado", Modelo = 65, Numero = "782344", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 96 ,Status = "Rejeitado", Modelo = 55, Numero = "74263874623", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 97, Status = "Rejeitado", Modelo = 65, Numero = "764238764", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 98, Status = "Rejeitado", Modelo = 65, Numero = "239764829364873", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 99 ,Status = "Rejeitado", Modelo = 65, Numero = "2364872384", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
                new Documento { Id = 100, Status = "Rejeitado", Modelo = 65, Numero = "876423", Serie = "58", Emissao = DateTime.Now.AddDays(-57), Destinatario = "Empresa FFF", Valor = 29500.00m },
            };
        }
    }

    public class Documento
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int Modelo { get; set; }
        public string Numero { get; set; }
        public string Serie { get; set; }
        public DateTime Emissao { get; set; }
        public string Destinatario { get; set; }
        public decimal Valor { get; set; }
    }
}
