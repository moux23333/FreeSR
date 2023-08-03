namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CancelExpeditionCsReq
	{
		[ProtoMember(12)] public int ExpeditionId;
	}
	
}
