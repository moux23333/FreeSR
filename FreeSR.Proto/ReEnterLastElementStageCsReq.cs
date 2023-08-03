namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReEnterLastElementStageCsReq
	{
		[ProtoMember(15)] public int StageId;
	}
	
}
