import { useEffect, useState } from 'react'
const api = 'http://localhost:5143/api/Obligations'
function App() {
  const [obligations, setObligations] = useState([])
  const [title, setTitle] = useState('')
  const [dueOn, setDueOn] = useState('')
  
  async function load() {
    const response = await fetch(api)
    setObligations(await response.json())
  }
  useEffect(() => {
    load()
  }, [])

  async function onSubmit(event) {
    event.preventDefault()
    await fetch(api, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify({ title, dueOn }),
    })
    setTitle('')
    setDueOn('')
    await load()
  }
  return (
    <main>
      <h1>Obligations</h1>
      <form onSubmit={onSubmit}>
        <input
          value={title}
          onChange={(event) => setTitle(event.target.value)}
          placeholder="Title"
          required
        />
        <input
          type="date"
          value={dueOn}
          onChange={(event) => setDueOn(event.target.value)}
          required
        />
        <button type="submit">Add</button>
      </form>
      <ul>
        {obligations.map((obligation) => (
          <li key={obligation.id}>
            {obligation.title} — {obligation.dueOn.slice(0, 10)}
          </li>
        ))}
      </ul>
    </main>
  )
}
export default App