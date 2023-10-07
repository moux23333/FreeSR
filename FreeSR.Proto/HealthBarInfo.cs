namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HealthBarInfo
	{
		[ProtoMember(1)] public int CurHp;
		[ProtoMember(2)] public int MaxHp;
	}

}
