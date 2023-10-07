namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetHeroBasicTypeInfoScRsp
	{
		[ProtoMember(6)] public bool IsPlayerInfoModified;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(12)] public Gender Gender;
		[ProtoMember(3)] public List<HeroBasicTypeInfo> BasicTypeInfoList;
		[ProtoMember(5)] public HeroBasicType CurBasicType;
		[ProtoMember(8)] public bool IsGenderModified;
	}

}
