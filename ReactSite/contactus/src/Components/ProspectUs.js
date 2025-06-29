import React, { useState } from 'react';
import axios from 'axios';

const ProspectUs = () => {
  const [formData, setFormData] = useState({
    name: '',
    email: '',
    phone: '',
    college: ''
  });

  const handleChange = (e) => {
    setFormData(prev => ({
      ...prev,
      [e.target.name]: e.target.value
    }));
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
https://localhost:7088/api/Form
    try {
      const response = await axios.post('/api/Form', formData); // ✅ Your API route
      alert('Form submitted: ' + response.data);
    } catch (err) {
      console.error(err);
      alert('Submission failed.');
    }
  };

  return (
    <div className="container mt-5">
      <h2 className="mb-4">Prospect Form</h2>
      <form onSubmit={handleSubmit}>
        <div className="mb-3">
          <label className="form-label">Name</label>
          <input name="name" className="form-control" onChange={handleChange} value={formData.name} />
        </div>
        <div className="mb-3">
          <label className="form-label">Email</label>
          <input name="email" className="form-control" onChange={handleChange} value={formData.email} />
        </div>
        <div className="mb-3">
          <label className="form-label">Phone</label>
          <input name="phone" className="form-control" onChange={handleChange} value={formData.phone} />
        </div>
        <div className="mb-3">
          <label className="form-label">College</label>
          <input name="college" className="form-control" onChange={handleChange} value={formData.college} />
        </div>
        <button className="btn btn-primary" type="submit">Submit</button>
      </form>
    </div>
  );
};

export default ProspectUs;
