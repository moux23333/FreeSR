namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HeroPath
	{
		[ProtoMember(1)] public int HeroPathType;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public int Exp;
	}

}
