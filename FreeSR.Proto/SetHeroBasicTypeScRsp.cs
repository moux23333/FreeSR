namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetHeroBasicTypeScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(14)] public HeroBasicType BasicType;
	}
	
}
