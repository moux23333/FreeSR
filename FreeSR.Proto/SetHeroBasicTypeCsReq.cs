namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetHeroBasicTypeCsReq
	{
		[ProtoMember(10)] public HeroBasicType BasicType;
	}
	
}
