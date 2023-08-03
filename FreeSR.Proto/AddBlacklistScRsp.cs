namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AddBlacklistScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(5)] public FKAEABKBFBP BlackInfo;
	}
	
}
