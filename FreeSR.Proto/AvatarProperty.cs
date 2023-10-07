namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarProperty
	{
		[ProtoMember(1)] public double MaxHp;
		[ProtoMember(2)] public double Attack;
		[ProtoMember(3)] public double Defence;
		[ProtoMember(4)] public double Speed;
		[ProtoMember(5)] public double LeftHp;
		[ProtoMember(6)] public double LeftSp;
		[ProtoMember(7)] public double MaxSp;
	}

}
