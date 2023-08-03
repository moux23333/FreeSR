namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptExpeditionScRsp
	{
		[ProtoMember(10)] public Expedition Expedition;
		[ProtoMember(2)] public int Retcode;
	}
	
}
