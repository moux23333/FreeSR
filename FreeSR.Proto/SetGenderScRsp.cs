namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGenderScRsp
	{
		[ProtoMember(2)] public HeroBasicType CurBasicType;
		[ProtoMember(5)] public int Retcode;
	}
	
}
