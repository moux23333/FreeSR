namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishSectionIdCsReq
	{
		[ProtoMember(9)] public int SectionId;
	}
	
}
