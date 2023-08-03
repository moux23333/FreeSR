namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGroupCustomSaveDataCsReq
	{
		[ProtoMember(12)] public int GroupId;
		[ProtoMember(10)] public int EntryId;
		[ProtoMember(15)] public string DLIAFGKODLD;
	}
	
}
