namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UpdateFloorSavedValueNotify
	{
		[ProtoMember(13)] public Dictionary<string, int> ALBJNLPPEFL;
	}
	
}
