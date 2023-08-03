namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerGetTokenScRsp
	{
		[ProtoMember(3)] public BlackInfo BlackInfo;
		[ProtoMember(2)] public int Uid;
		[ProtoMember(8)] public string Msg;
		[ProtoMember(10)] public long SecretKeySeed;
		[ProtoMember(15)] public int Retcode;
	}
	
}
