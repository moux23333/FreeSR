namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ApplyFriendScRsp
	{
		[ProtoMember(9)] public int Uid;
		[ProtoMember(2)] public int Retcode;
	}
	
}
