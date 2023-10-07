namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneMonster
	{
		[ProtoMember(6)] public int MaxHp;
		[ProtoMember(12)] public int CurHp;
		[ProtoMember(15)] public int MonsterId;
	}

}
