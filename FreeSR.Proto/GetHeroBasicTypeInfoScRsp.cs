namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetHeroBasicTypeInfoScRsp
	{
		[ProtoMember(1)] public bool IsGenderModified;
		[ProtoMember(10)] public bool IsPlayerInfoModified;
		[ProtoMember(13)] public HeroBasicType CurBasicType;
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(3)] public Gender Gender;
		[ProtoMember(11)] public List<HeroBasicTypeInfo> BasicTypeInfoList;
	}
	
}
