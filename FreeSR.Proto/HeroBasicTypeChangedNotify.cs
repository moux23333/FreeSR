namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HeroBasicTypeChangedNotify
	{
		[ProtoMember(11)] public HeroBasicType CurBasicType;
	}
	
}
