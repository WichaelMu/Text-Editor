using System.Diagnostics;

namespace Engine
{
	/// <summary>The <see langword="interface"/> that <see cref="Form"/>s need to implement for the Tick Component.</summary>
	/// <typeparam name="F">The Form that is requesting a Tick Component.</typeparam>
	public interface ITick<F> where F : Form
	{
		/// <summary><see langword="true"/> if <typeparamref name="F"/> can <see cref="Tick(float)"/>.</summary>
		public bool bCanTick { get; }

		/// <summary><see langword="true"/> if <typeparamref name="F"/> is currently using <see cref="Tick(float)"/>.</summary>
		public bool bIsTicking { get; set; }

		/// <summary>The Tick Logic.</summary>
		/// <remarks>This is called every frame.</remarks>
		/// <param name="DeltaTime">The time taken for the last frame to be processed.</param>
		public void Tick(float DeltaTime);

		/// <summary>Begins executing this Tick Component.</summary>
		public void InitialiseTickComponent()
		{
			BeginTick(this, null);
		}

		/// <summary>This Tick Component's owning <typeparamref name="F"/>.</summary>
		public Form ThisAsForm()
		{
			return (Form)this;
		}

		/// <summary>The implementation of this Tick Component's core logic.</summary>
		async void BeginTick(object Sender, EventArgs E)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			long Prev = sw.ElapsedMilliseconds;

			while (true)
			{
				long DeltaTime = sw.ElapsedMilliseconds - Prev;
				Prev = sw.ElapsedMilliseconds;

				await Task.Delay(1);

				if (bCanTick)
					Tick(DeltaTime * .001f);
			}
		}
	}
}
