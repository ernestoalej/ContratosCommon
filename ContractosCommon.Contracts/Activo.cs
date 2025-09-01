namespace ContractosCommon.Contracts
{
	public record Activo
	{
		// clase pasra exponer los activos de expediente
		public int Id { get; set; }
		public required string Nombre { get; set; }		
		public required string CodActivo { get; set; }
	}
}
