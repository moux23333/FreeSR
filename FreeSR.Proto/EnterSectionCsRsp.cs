namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSectionCsRsp
	{
		[ProtoMember(10)] public int Retcode;
	}
	
}
