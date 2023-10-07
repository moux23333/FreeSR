namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AttackDamageProperty
	{
		[ProtoMember(1)] public string AttackType;
		[ProtoMember(2)] public double Damage;
	}

}
