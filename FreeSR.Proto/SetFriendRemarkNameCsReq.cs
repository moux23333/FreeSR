namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetFriendRemarkNameCsReq
	{
		[ProtoMember(2)] public int Uid;
		[ProtoMember(15)] public string NIKOAKBNGML;
	}
	
}
