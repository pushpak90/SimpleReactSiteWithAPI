import './App.css';
import Footer from './Components/Footer';
import Header from './Components/Header';
import RegForm from './Components/RegForm';
import 'bootstrap/dist/css/bootstrap.min.css';
import ThankYou from './ThankYou';
import Login from './Components/Login';
import EmpReg from './Components/EmpReg';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

function App() {
  return (
     <Router>
      <Header />
      <div className="container mt-4">
        <Routes>
          <Route path="/" element={<RegForm />} />
          <Route path="/thank-you" element={<ThankYou/>} />
          <Route path="/login" element={<Login/>} />
          <Route path="/empreg" element={<EmpReg/>} />
        </Routes>
      </div>
      <Footer />
    </Router>
  );
}

export default App;
