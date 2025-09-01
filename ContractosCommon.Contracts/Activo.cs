namespace ContractosCommon.Contracts
{
    public record Activo
    {	
		public int Id { get; set; }
		public required string Nombre { get; set; }
	}
}
