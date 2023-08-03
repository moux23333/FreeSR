namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetFriendRemarkNameScRsp
	{
		[ProtoMember(2)] public string NIKOAKBNGML;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(4)] public int Uid;
	}
	
}
