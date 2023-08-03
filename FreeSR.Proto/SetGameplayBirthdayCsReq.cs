namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGameplayBirthdayCsReq
	{
		[ProtoMember(8)] public int Birthday;
	}
	
}
