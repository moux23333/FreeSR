namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialGuideCsReq
	{
		[ProtoMember(9)] public int GroupId;
	}

}
