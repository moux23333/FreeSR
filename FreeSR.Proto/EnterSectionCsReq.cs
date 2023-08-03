namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSectionCsReq
	{
		[ProtoMember(9)] public int SectionId;
	}
	
}
