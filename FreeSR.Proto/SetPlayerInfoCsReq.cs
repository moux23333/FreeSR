namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetPlayerInfoCsReq
	{
		[ProtoMember(15)] public Gender Gender;
		[ProtoMember(2)] public bool IsModify;
		[ProtoMember(9)] public string Nickname;
	}
	
}
