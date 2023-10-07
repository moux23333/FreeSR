namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerGetTokenScRsp
	{
		[ProtoMember(7)] public long SecretKeySeed;
		[ProtoMember(1)] public int Uid;
		[ProtoMember(2)] public BlackInfo BlackInfo;
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(8)] public string Msg;
	}

}
