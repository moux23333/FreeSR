namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PunkLordBattleAvatar
	{
		[ProtoMember(1)] public int AvatarId;
		[ProtoMember(2)] public int AvatarLevel;
	}

}
