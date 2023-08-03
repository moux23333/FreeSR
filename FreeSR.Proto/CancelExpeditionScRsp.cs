namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CancelExpeditionScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(12)] public int ExpeditionId;
	}
	
}
