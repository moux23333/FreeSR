namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DeleteBlacklistScRsp
	{
		[ProtoMember(2)] public int Uid;
		[ProtoMember(6)] public int Retcode;
	}
	
}
