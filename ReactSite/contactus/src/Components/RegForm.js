import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';


const RegForm = () => {
     const navigate = useNavigate();
    const [formData, setFormData] = useState({
        fullName: '',
        email: '',
        phoneNumber: '',
        collegeName: ''
    });

    // const navigate = useNavigate();
    const handleChange = (e) => {
        setFormData((prev) => ({
            ...prev,
            [e.target.name]: e.target.value,
        }));
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        console.log('Submitted Data:', formData);

        try {
            const response = await fetch('https://localhost:7005/api/Form', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify(formData),
            });

            if (response.ok) {
                const result = await response.json();
                console.log('Success:', result);
                navigate('/thank-you');
            } else {
                console.error('Server error:', response.statusText);
            }
        } catch (error) {
            console.error('Network error:', error);
        }
    };



    return (
        <div className="container mt-5" style={{ maxWidth: '500px' }}>
            <h3 className="mb-4 text-center">Registration Form</h3>
            <form onSubmit={handleSubmit} className="bg-light p-4 rounded shadow">
                <div className="mb-3">
                    <label className="form-label">Full Name</label>
                    <input
                        type="text"
                        name="fullName"
                        value={formData.fullName}
                        onChange={handleChange}
                        className="form-control"
                        placeholder="Enter your full name"
                    />
                </div>

                <div className="mb-3">
                    <label className="form-label">Email address</label>
                    <input
                        type="email"
                        name='email'
                        value={formData.email}
                        onChange={handleChange}
                        className="form-control"
                        placeholder="example@email.com"
                    />
                </div>

                <div className="mb-3">
                    <label className="form-label">Phone Number</label>
                    <input
                        type="tel"
                        name='phoneNumber'
                        value={formData.phoneNumber}
                        onChange={handleChange}
                        className="form-control"
                        placeholder="e.g. 9876543210"
                    />
                </div>

                <div className="mb-3">
                    <label className="form-label">College Name</label>
                    <input
                        type="text"
                        name='collegeName'
                        value={formData.collegeName}
                        onChange={handleChange}
                        className="form-control"
                        placeholder="Your College Name"
                    />
                </div>

                <button type="submit" className="btn btn-primary w-100">
                    Submit
                </button>
            </form>
        </div>
    );
};

export default RegForm;
