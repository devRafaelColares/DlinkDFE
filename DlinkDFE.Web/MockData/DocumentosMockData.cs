namespace DlinkDFE.Web.MockData
{
    public static class DocumentosMockData
    {
        public static List<Documento> GetDocumentos()
        {
            return new List<Documento>
            {
                new Documento { Id = 1, Status = "Autorizado", Modelo = 55, Numero = "123456", Serie = "1", Emissao = DateTime.Now.AddDays(-1), Destinatario = "Empresa A", Valor = 1000.00m },
                new Documento { Id = 2, Status = "Pendente", Modelo = 65, Numero = "123457", Serie = "2", Emissao = DateTime.Now, Destinatario = "Empresa B", Valor = 1500.00m },
                new Documento { Id = 3, Status = "Autorizado", Modelo = 55, Numero = "123458", Serie = "3", Emissao = DateTime.Now.AddDays(-2), Destinatario = "Empresa C", Valor = 2000.00m },
                new Documento { Id = 4, Status = "Rejeitado", Modelo = 65, Numero = "123459", Serie = "4", Emissao = DateTime.Now.AddDays(-3), Destinatario = "Empresa D", Valor = 2500.00m },
                new Documento { Id = 5, Status = "Autorizado", Modelo = 55, Numero = "123460", Serie = "5", Emissao = DateTime.Now.AddDays(-4), Destinatario = "Empresa E", Valor = 3000.00m },
                new Documento { Id = 6, Status = "Pendente", Modelo = 65, Numero = "123461", Serie = "6", Emissao = DateTime.Now.AddDays(-5), Destinatario = "Empresa F", Valor = 3500.00m },
                new Documento { Id = 7, Status = "Autorizado", Modelo = 55, Numero = "123462", Serie = "7", Emissao = DateTime.Now.AddDays(-6), Destinatario = "Empresa G", Valor = 4000.00m },
                new Documento { Id = 8, Status = "Rejeitado", Modelo = 65, Numero = "123463", Serie = "8", Emissao = DateTime.Now.AddDays(-7), Destinatario = "Empresa H", Valor = 4500.00m },
                new Documento { Id = 9, Status = "Autorizado", Modelo = 55, Numero = "123464", Serie = "9", Emissao = DateTime.Now.AddDays(-8), Destinatario = "Empresa I", Valor = 5000.00m },
                new Documento { Id = 10, Status = "Pendente", Modelo = 65, Numero = "123465", Serie = "10", Emissao = DateTime.Now.AddDays(-9), Destinatario = "Empresa J", Valor = 5500.00m }
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
