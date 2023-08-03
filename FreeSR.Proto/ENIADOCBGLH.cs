namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ENIADOCBGLH
	{
		[ProtoMember(14)] public int AvatarId;
		[ProtoMember(13)] public int Damage;
		[ProtoMember(12)] public int PFLMBCJONAM;
		[ProtoMember(8)] public long Time;
		[ProtoMember(15)] public string Nickname;
		[ProtoMember(1)] public int Uid;
		[ProtoMember(10)] public int StageId;
	}
	
}
