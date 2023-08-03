namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptExpeditionCsReq
	{
		[ProtoMember(9)] public Expedition Expedition;
	}
	
}
