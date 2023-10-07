namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MonsterProperty
	{
		[ProtoMember(1)] public double MaxHp;
		[ProtoMember(2)] public double Attack;
		[ProtoMember(3)] public double Defence;
		[ProtoMember(4)] public double Shield;
		[ProtoMember(5)] public double Speed;
		[ProtoMember(6)] public double LeftHp;
		[ProtoMember(7)] public double Gopcmnbbgdj;
	}

}
