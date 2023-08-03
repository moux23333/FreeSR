namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialGuideCsReq
	{
		[ProtoMember(3)] public int GroupId;
	}
	
}
