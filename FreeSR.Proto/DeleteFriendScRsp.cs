namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DeleteFriendScRsp
	{
		[ProtoMember(14)] public int Uid;
		[ProtoMember(3)] public int Retcode;
	}
	
}
