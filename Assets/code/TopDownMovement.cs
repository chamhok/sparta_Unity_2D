using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
        private TopDownController _controller;

        private Vector2 _movementDirection = Vector2.zero;
        private Rigidbody2D _rigidbody;

        private void Awake()
        {
                _controller = GetComponent<TopDownController>();
                _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
                _controller.onMoveEvent += Move;
        }

        private void FixedUpdate()
        {
                ApplyMovment(_movementDirection);
        }

        private void Move(Vector2 direction)
        {
                _movementDirection = direction;
        }

        private void ApplyMovment(Vector2 direction)
        {
                direction = direction * 5;

                _rigidbody.velocity = direction;
        }
}