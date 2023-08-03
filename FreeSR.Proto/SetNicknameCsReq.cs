namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetNicknameCsReq
	{
		[ProtoMember(3)] public bool IsModify;
		[ProtoMember(15)] public string Nickname;
	}
	
}
