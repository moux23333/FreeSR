namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSceneMapInfoCsReq
	{
		[ProtoMember(9)] public int EntryId;
		[ProtoMember(2)] public bool Dbhfekhniih;
		[ProtoMember(15)] public List<int> EntryIdList;
	}

}
