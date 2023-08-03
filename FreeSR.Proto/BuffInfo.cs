namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BuffInfo
	{
		[ProtoMember(5)] public int Level;
		[ProtoMember(2)] public int BaseAvatarId;
		[ProtoMember(8)] public Dictionary<string,float> DynamicValues;
		[ProtoMember(7)] public int Count;
		[ProtoMember(3)] public float LifeTime;
		[ProtoMember(9)] public int BuffId;
		[ProtoMember(1)] public long AddTimeMs;
	}
	
}
